﻿namespace XrmToolBox.Forms
{
    partial class NewConnectionVersion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbReleaseNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPluginTitle = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.llUpdateNextStart = new System.Windows.Forms.LinkLabel();
            this.cbbReminder = new System.Windows.Forms.ComboBox();
            this.llDoNotUpdate = new System.Windows.Forms.LinkLabel();
            this.llUpdateNow = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbReleaseNotes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSummary);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlFooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(38, 38, 38, 38);
            this.panel1.Size = new System.Drawing.Size(960, 878);
            this.panel1.TabIndex = 0;
            // 
            // rtbReleaseNotes
            // 
            this.rtbReleaseNotes.BackColor = System.Drawing.Color.White;
            this.rtbReleaseNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReleaseNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReleaseNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbReleaseNotes.Location = new System.Drawing.Point(38, 362);
            this.rtbReleaseNotes.Name = "rtbReleaseNotes";
            this.rtbReleaseNotes.ReadOnly = true;
            this.rtbReleaseNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbReleaseNotes.Size = new System.Drawing.Size(884, 353);
            this.rtbReleaseNotes.TabIndex = 15;
            this.rtbReleaseNotes.Text = "";
            this.rtbReleaseNotes.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbReleaseNotes_LinkClicked);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 273);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 38, 0, 0);
            this.label1.Size = new System.Drawing.Size(884, 89);
            this.label1.TabIndex = 14;
            this.label1.Tag = "A new version of the tool {0} is available in the Tool Library.";
            this.label1.Text = "What\'s new";
            // 
            // lblSummary
            // 
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(38, 184);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblSummary.Size = new System.Drawing.Size(884, 89);
            this.lblSummary.TabIndex = 17;
            this.lblSummary.Tag = "A new version of the tool {0} is available in the Tool Library.";
            this.lblSummary.Text = "A new version of controls that allow to connect to your Microsoft Dynamics 365 an" +
    "d Microsoft Dataverse is available.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPluginTitle);
            this.panel2.Controls.Add(this.lblNewVersion);
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(38, 38);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panel2.Size = new System.Drawing.Size(884, 146);
            this.panel2.TabIndex = 8;
            // 
            // lblPluginTitle
            // 
            this.lblPluginTitle.AutoEllipsis = true;
            this.lblPluginTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPluginTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginTitle.Location = new System.Drawing.Point(141, 2);
            this.lblPluginTitle.Name = "lblPluginTitle";
            this.lblPluginTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblPluginTitle.Size = new System.Drawing.Size(743, 91);
            this.lblPluginTitle.TabIndex = 1;
            this.lblPluginTitle.Text = "XrmToolBox Connection controls";
            this.lblPluginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNewVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVersion.Location = new System.Drawing.Point(141, 93);
            this.lblNewVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblNewVersion.Size = new System.Drawing.Size(743, 53);
            this.lblNewVersion.TabIndex = 2;
            this.lblNewVersion.Text = "[new version]";
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::XrmToolBox.Properties.Resources.logo_0400;
            this.pbLogo.Location = new System.Drawing.Point(0, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(141, 144);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.llUpdateNextStart);
            this.pnlFooter.Controls.Add(this.cbbReminder);
            this.pnlFooter.Controls.Add(this.llDoNotUpdate);
            this.pnlFooter.Controls.Add(this.llUpdateNow);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(38, 715);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(884, 125);
            this.pnlFooter.TabIndex = 10;
            // 
            // llUpdateNextStart
            // 
            this.llUpdateNextStart.ActiveLinkColor = System.Drawing.Color.Green;
            this.llUpdateNextStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llUpdateNextStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.llUpdateNextStart.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llUpdateNextStart.Location = new System.Drawing.Point(5, 78);
            this.llUpdateNextStart.MinimumSize = new System.Drawing.Size(314, 2);
            this.llUpdateNextStart.Name = "llUpdateNextStart";
            this.llUpdateNextStart.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.llUpdateNextStart.Size = new System.Drawing.Size(373, 46);
            this.llUpdateNextStart.TabIndex = 3;
            this.llUpdateNextStart.TabStop = true;
            this.llUpdateNextStart.Text = "Update on next XrmToolBox run";
            this.llUpdateNextStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llUpdateNextStart.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llUpdateNextStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUpdateNextStart_LinkClicked);
            // 
            // cbbReminder
            // 
            this.cbbReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbReminder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReminder.FormattingEnabled = true;
            this.cbbReminder.Items.AddRange(new object[] {
            "Don\'t remind me for 1 day",
            "Don\'t remind me for 2 days",
            "Don\'t remind me for 3 days",
            "Don\'t remind me for this version"});
            this.cbbReminder.Location = new System.Drawing.Point(601, 30);
            this.cbbReminder.Name = "cbbReminder";
            this.cbbReminder.Size = new System.Drawing.Size(254, 28);
            this.cbbReminder.TabIndex = 2;
            // 
            // llDoNotUpdate
            // 
            this.llDoNotUpdate.ActiveLinkColor = System.Drawing.Color.Red;
            this.llDoNotUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llDoNotUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDoNotUpdate.ForeColor = System.Drawing.Color.Red;
            this.llDoNotUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llDoNotUpdate.LinkColor = System.Drawing.Color.Red;
            this.llDoNotUpdate.Location = new System.Drawing.Point(427, 14);
            this.llDoNotUpdate.Name = "llDoNotUpdate";
            this.llDoNotUpdate.Size = new System.Drawing.Size(144, 57);
            this.llDoNotUpdate.TabIndex = 1;
            this.llDoNotUpdate.TabStop = true;
            this.llDoNotUpdate.Text = "No thanks";
            this.llDoNotUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llDoNotUpdate.VisitedLinkColor = System.Drawing.Color.Red;
            this.llDoNotUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDoNotUpdate_LinkClicked);
            this.llDoNotUpdate.Paint += new System.Windows.Forms.PaintEventHandler(this.llDoNotUpdate_Paint);
            // 
            // llUpdateNow
            // 
            this.llUpdateNow.ActiveLinkColor = System.Drawing.Color.Green;
            this.llUpdateNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llUpdateNow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUpdateNow.ForeColor = System.Drawing.Color.Green;
            this.llUpdateNow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llUpdateNow.LinkColor = System.Drawing.Color.Green;
            this.llUpdateNow.Location = new System.Drawing.Point(35, 14);
            this.llUpdateNow.MinimumSize = new System.Drawing.Size(314, 2);
            this.llUpdateNow.Name = "llUpdateNow";
            this.llUpdateNow.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.llUpdateNow.Size = new System.Drawing.Size(314, 57);
            this.llUpdateNow.TabIndex = 0;
            this.llUpdateNow.TabStop = true;
            this.llUpdateNow.Text = "Update Now";
            this.llUpdateNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llUpdateNow.VisitedLinkColor = System.Drawing.Color.Green;
            this.llUpdateNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUpdateNow_LinkClicked);
            this.llUpdateNow.Paint += new System.Windows.Forms.PaintEventHandler(this.llUpdateNow_Paint);
            // 
            // NewConnectionVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 878);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(893, 559);
            this.Name = "NewConnectionVersion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update available!";
            this.Resize += new System.EventHandler(this.NewPluginVersion_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPluginTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.LinkLabel llDoNotUpdate;
        private System.Windows.Forms.LinkLabel llUpdateNow;
        private System.Windows.Forms.RichTextBox rtbReleaseNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbReminder;
        private System.Windows.Forms.Label lblNewVersion;
        private System.Windows.Forms.LinkLabel llUpdateNextStart;
        private System.Windows.Forms.Label lblSummary;
    }
}