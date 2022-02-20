﻿using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;
using System.Reflection;
using System.ServiceModel;
using System.Windows.Forms;
using XrmToolBox.Extensibility.Interfaces;

namespace XrmToolBox.Extensibility.Forms
{
    public partial class ErrorDetail : Form
    {
        private PluginControlBase owner;
        private DateTime timestamp;
        private Exception exception;
        private string extrainfo;
        private bool allownewissue;

        /// <summary>
        /// Generic Error Details show a dialog
        /// </summary>
        /// <param name="owner">The owner shall be the tool that calles it, usually `this`.</param>
        /// <param name="exception">Exception or any descendants class</param>
        /// <param name="heading">Title of the problem the tool want to show. Null = 'Error Detail'</param>
        /// <param name="extrainfo">If the tool may have more information, this will be used to a new issue.</param>
        /// <param name="allownewissue">If tool is `IGitHubPlugin` and send this as True new issues can be added by the user.</param>
        public static void ShowDialog(PluginControlBase owner, Exception exception, string heading = null, string extrainfo = null, bool allownewissue = true)
        {
            if (owner == null || exception == null)
            {
                return;
            }
            new ErrorDetail(owner, exception, heading, extrainfo, allownewissue).ShowDialog(owner);
        }

        public static void CreateNewIssueFromError(PluginControlBase tool, Exception error, string moreinfo)
            => CreateNewIssue(tool, "```\n" + ToTypeString(error) + ":\n" + error.Message + "\n" + error.StackTrace + "\n```", moreinfo);

        public static void CreateNewIssue(PluginControlBase tool, string addedtext, string extrainfo)
        {
            if (tool == null || !(tool is IGitHubPlugin githubtool))
            {
                return;
            }
            var additionalInfo = "?body=[Write any error info to resolve easier]\n\n---\n";
            additionalInfo += addedtext.Replace("   at ", "- ") + "\n\n---\n";
            if (!string.IsNullOrWhiteSpace(extrainfo))
            {
                additionalInfo += "\n```\n" + extrainfo + "\n```\n---\n";
            }
            additionalInfo += $"- {tool.ProductName} Version: {Assembly.GetExecutingAssembly().GetName().Version}\n";
            if (tool.ConnectionDetail != null)
            {
                additionalInfo += $"- DB Version: {tool.ConnectionDetail.OrganizationVersion}\n";
                additionalInfo += $"- Deployment: {(tool.ConnectionDetail.WebApplicationUrl.ToLower().Contains("dynamics.com") ? "Online" : "OnPremise")}\n";
            }
            additionalInfo = additionalInfo.Replace("\n", "%0A").Replace("&", "%26").Replace(" ", "%20");
            var url = $"https://github.com/{githubtool.UserName}/{githubtool.RepositoryName}/issues/new";
            Process.Start(url + additionalInfo);
        }

        private ErrorDetail(PluginControlBase owner, Exception exception, string heading, string extrainfo, bool allownewissue)
        {
            this.owner = owner;
            this.exception = exception;
            this.extrainfo = extrainfo;
            this.allownewissue = allownewissue;
            timestamp = DateTime.Now;
            InitializeComponent();
            if (!string.IsNullOrEmpty(heading))
            {
                Text = heading;
            }
            AddErrorInfo(exception);
            Height = 200;
        }

        private void AddErrorInfo(Exception error)
        {
            try
            {
                var msg = error.Message;
                if (error is FaultException<OrganizationServiceFault> srcexc)
                {
                    msg = srcexc.Message;
                    if (srcexc.Detail is OrganizationServiceFault orgerr)
                    {
                        msg = orgerr.Message;
                        if (orgerr.InnerFault != null)
                        {
                            msg = orgerr.InnerFault.Message;
                        }
                        txtErrorCode.Text = "0x" + orgerr.ErrorCode.ToString("X");
                    }
                }
                if (msg.StartsWith("System") && msg.Contains(": ") && msg.Split(':')[0].Length < 50)
                {
                    msg = msg.Substring(msg.IndexOf(':') + 1);
                }
                if (msg.Contains("MetadataCacheDetails: "))
                {
                    msg = msg.Substring(0, msg.IndexOf("MetadataCacheDetails"));
                }
                if (msg.Contains("   at "))
                {
                    msg = msg.Substring(0, msg.IndexOf("   at "));
                }
                msg = msg.Trim();
                txtInfo.Text = msg;
                txtException.Text = ToTypeString(error);
                txtMessage.Text = error.Message;
                txtCallStack.Text = error.StackTrace.Trim();
            }
            catch
            {
                txtInfo.Text = error.Message;
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (Height < 300)
            {
                btnDetails.Text = "Hide Details";
                panDetails.Visible = true;
                btnCopy.Visible = true;
                btnIssue.Visible = allownewissue;
                Height = 550;
            }
            else
            {
                btnDetails.Text = "Show Details";
                panDetails.Visible = false;
                btnCopy.Visible = false;
                btnIssue.Visible = false;
                Height = 200;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var details = "Error Time: " + timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\n";
            details += txtException.Text;
            if (!string.IsNullOrEmpty(txtErrorCode.Text))
            {
                details += $" ({txtErrorCode.Text})";
            }
            details += $"\n{txtMessage.Text}";
            details += $"\n{txtCallStack.Text}";
            Clipboard.SetText(details);
            MessageBox.Show("Copied all details.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            CreateNewIssueFromError(owner, exception, extrainfo);
            TopMost = false;
        }

        private static string ToTypeString(Exception ex)
        {
            var type = ex.GetType().ToString();
            if (type.Contains("`1["))
            {
                type = type.Replace("`1[", "<").Replace("]", ">");
            }
            return type;
        }
    }
}
