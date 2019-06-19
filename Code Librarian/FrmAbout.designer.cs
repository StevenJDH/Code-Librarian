namespace Code_Librarian
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTitleVer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtLicense = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkGitHub = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlButtonImage = new System.Windows.Forms.Panel();
            this.lblButton = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.pnlButtonImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 296);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblTitleVer
            // 
            this.lblTitleVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleVer.Location = new System.Drawing.Point(43, 8);
            this.lblTitleVer.Name = "lblTitleVer";
            this.lblTitleVer.Size = new System.Drawing.Size(557, 16);
            this.lblTitleVer.TabIndex = 1;
            this.lblTitleVer.Text = "Code Librarian v0.0.0.0 (yyyy-MM-dd)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtLicense);
            this.groupBox1.Location = new System.Drawing.Point(8, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GNU General Public License";
            // 
            // rtxtLicense
            // 
            this.rtxtLicense.BackColor = System.Drawing.Color.White;
            this.rtxtLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtLicense.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.rtxtLicense.Location = new System.Drawing.Point(8, 16);
            this.rtxtLicense.Name = "rtxtLicense";
            this.rtxtLicense.ReadOnly = true;
            this.rtxtLicense.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtLicense.Size = new System.Drawing.Size(576, 144);
            this.rtxtLicense.TabIndex = 5;
            this.rtxtLicense.Text = resources.GetString("rtxtLicense.Text");
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "C# source code is available on GitHub: ";
            // 
            // lnkGitHub
            // 
            this.lnkGitHub.Location = new System.Drawing.Point(200, 88);
            this.lnkGitHub.Name = "lnkGitHub";
            this.lnkGitHub.Size = new System.Drawing.Size(400, 16);
            this.lnkGitHub.TabIndex = 4;
            this.lnkGitHub.TabStop = true;
            this.lnkGitHub.Text = "https://github.com/StevenJDH/Code-Librarian";
            this.lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGitHub_LinkClicked);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Copyright (C) 2019 Steven Jenkins De Haro";
            // 
            // pnlButtonImage
            // 
            this.pnlButtonImage.BackgroundImage = global::Code_Librarian.Properties.Resources.donation_button;
            this.pnlButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButtonImage.Controls.Add(this.lblButton);
            this.pnlButtonImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlButtonImage.Location = new System.Drawing.Point(8, 295);
            this.pnlButtonImage.Name = "pnlButtonImage";
            this.pnlButtonImage.Size = new System.Drawing.Size(112, 32);
            this.pnlButtonImage.TabIndex = 8;
            this.pnlButtonImage.Click += new System.EventHandler(this.PnlButtonImage_Click);
            // 
            // lblButton
            // 
            this.lblButton.BackColor = System.Drawing.Color.Orange;
            this.lblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblButton.Location = new System.Drawing.Point(8, 8);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(96, 16);
            this.lblButton.TabIndex = 12;
            this.lblButton.Text = "Donate...";
            this.lblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblButton.Click += new System.EventHandler(this.LblButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Code_Librarian.Properties.Resources.Logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(8, 8);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(32, 32);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 9;
            this.LogoPictureBox.TabStop = false;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 338);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.pnlButtonImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkGitHub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitleVer);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Code Librarian";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnlButtonImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTitleVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkGitHub;
        private System.Windows.Forms.RichTextBox rtxtLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlButtonImage;
        private System.Windows.Forms.Label lblButton;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
    }
}