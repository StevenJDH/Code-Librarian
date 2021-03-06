﻿namespace Code_Librarian
{
    partial class FrmView
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPhoneEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneEmail = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDateUpdated = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblOrigDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(514, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 33);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(376, 8);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(131, 33);
            this.btnCopy.TabIndex = 46;
            this.btnCopy.Text = "Copy Code to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(8, 160);
            this.txtCode.MaxLength = 60000;
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(638, 285);
            this.txtCode.TabIndex = 66;
            this.txtCode.TabStop = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AcceptsReturn = true;
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAuthor.Location = new System.Drawing.Point(8, 24);
            this.txtAuthor.MaxLength = 0;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAuthor.Size = new System.Drawing.Size(208, 20);
            this.txtAuthor.TabIndex = 63;
            this.txtAuthor.TabStop = false;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhoneEmail
            // 
            this.txtPhoneEmail.AcceptsReturn = true;
            this.txtPhoneEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtPhoneEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneEmail.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhoneEmail.Location = new System.Drawing.Point(224, 24);
            this.txtPhoneEmail.MaxLength = 0;
            this.txtPhoneEmail.Name = "txtPhoneEmail";
            this.txtPhoneEmail.ReadOnly = true;
            this.txtPhoneEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneEmail.Size = new System.Drawing.Size(144, 20);
            this.txtPhoneEmail.TabIndex = 62;
            this.txtPhoneEmail.TabStop = false;
            this.txtPhoneEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhoneEmail
            // 
            this.lblPhoneEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPhoneEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhoneEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPhoneEmail.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneEmail.Location = new System.Drawing.Point(224, 8);
            this.lblPhoneEmail.Name = "lblPhoneEmail";
            this.lblPhoneEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhoneEmail.Size = new System.Drawing.Size(144, 17);
            this.lblPhoneEmail.TabIndex = 65;
            this.lblPhoneEmail.Text = "Phone Number/Email";
            this.lblPhoneEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAuthor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuthor.Location = new System.Drawing.Point(8, 8);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAuthor.Size = new System.Drawing.Size(208, 17);
            this.lblAuthor.TabIndex = 64;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKeywords
            // 
            this.txtKeywords.AcceptsReturn = true;
            this.txtKeywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtKeywords.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeywords.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeywords.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKeywords.Location = new System.Drawing.Point(332, 104);
            this.txtKeywords.MaxLength = 0;
            this.txtKeywords.Multiline = true;
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.ReadOnly = true;
            this.txtKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeywords.Size = new System.Drawing.Size(313, 35);
            this.txtKeywords.TabIndex = 53;
            this.txtKeywords.TabStop = false;
            // 
            // txtLanguage
            // 
            this.txtLanguage.AcceptsReturn = true;
            this.txtLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtLanguage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLanguage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLanguage.Location = new System.Drawing.Point(523, 64);
            this.txtLanguage.MaxLength = 0;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLanguage.Size = new System.Drawing.Size(121, 20);
            this.txtLanguage.TabIndex = 52;
            this.txtLanguage.TabStop = false;
            this.txtLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPurpose
            // 
            this.txtPurpose.AcceptsReturn = true;
            this.txtPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurpose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurpose.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPurpose.Location = new System.Drawing.Point(8, 104);
            this.txtPurpose.MaxLength = 0;
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.ReadOnly = true;
            this.txtPurpose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPurpose.Size = new System.Drawing.Size(317, 35);
            this.txtPurpose.TabIndex = 51;
            this.txtPurpose.TabStop = false;
            // 
            // txtVersion
            // 
            this.txtVersion.AcceptsReturn = true;
            this.txtVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVersion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVersion.Location = new System.Drawing.Point(456, 64);
            this.txtVersion.MaxLength = 0;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVersion.Size = new System.Drawing.Size(60, 20);
            this.txtVersion.TabIndex = 50;
            this.txtVersion.TabStop = false;
            this.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.AcceptsReturn = true;
            this.txtDateCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtDateCreated.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateCreated.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCreated.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDateCreated.Location = new System.Drawing.Point(280, 64);
            this.txtDateCreated.MaxLength = 0;
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateCreated.Size = new System.Drawing.Size(81, 20);
            this.txtDateCreated.TabIndex = 49;
            this.txtDateCreated.TabStop = false;
            this.txtDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTitle.Location = new System.Drawing.Point(8, 64);
            this.txtTitle.MaxLength = 0;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitle.Size = new System.Drawing.Size(265, 20);
            this.txtTitle.TabIndex = 48;
            this.txtTitle.TabStop = false;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateUpdated
            // 
            this.txtDateUpdated.AcceptsReturn = true;
            this.txtDateUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtDateUpdated.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateUpdated.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateUpdated.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDateUpdated.Location = new System.Drawing.Point(368, 64);
            this.txtDateUpdated.MaxLength = 0;
            this.txtDateUpdated.Name = "txtDateUpdated";
            this.txtDateUpdated.ReadOnly = true;
            this.txtDateUpdated.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateUpdated.Size = new System.Drawing.Size(81, 20);
            this.txtDateUpdated.TabIndex = 47;
            this.txtDateUpdated.TabStop = false;
            this.txtDateUpdated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCode.Location = new System.Drawing.Point(8, 144);
            this.lblCode.Name = "lblCode";
            this.lblCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCode.Size = new System.Drawing.Size(638, 17);
            this.lblCode.TabIndex = 61;
            this.lblCode.Text = "Code Snippet";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKeywords
            // 
            this.lblKeywords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeywords.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblKeywords.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKeywords.Location = new System.Drawing.Point(332, 88);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKeywords.Size = new System.Drawing.Size(313, 17);
            this.lblKeywords.TabIndex = 60;
            this.lblKeywords.Text = "Searchable Keywords";
            this.lblKeywords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPurpose
            // 
            this.lblPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPurpose.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPurpose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPurpose.Location = new System.Drawing.Point(8, 88);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPurpose.Size = new System.Drawing.Size(317, 17);
            this.lblPurpose.TabIndex = 59;
            this.lblPurpose.Text = "Purpose/Function of the Code";
            this.lblPurpose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLanguage
            // 
            this.lblLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLanguage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLanguage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLanguage.Location = new System.Drawing.Point(523, 48);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLanguage.Size = new System.Drawing.Size(121, 17);
            this.lblLanguage.TabIndex = 58;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVersion.Location = new System.Drawing.Point(456, 48);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVersion.Size = new System.Drawing.Size(60, 17);
            this.lblVersion.TabIndex = 57;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpdateDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUpdateDate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUpdateDate.Location = new System.Drawing.Point(368, 48);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUpdateDate.Size = new System.Drawing.Size(81, 17);
            this.lblUpdateDate.TabIndex = 56;
            this.lblUpdateDate.Text = "Last Update";
            this.lblUpdateDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOrigDate
            // 
            this.lblOrigDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOrigDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrigDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOrigDate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrigDate.Location = new System.Drawing.Point(280, 48);
            this.lblOrigDate.Name = "lblOrigDate";
            this.lblOrigDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOrigDate.Size = new System.Drawing.Size(81, 17);
            this.lblOrigDate.TabIndex = 55;
            this.lblOrigDate.Text = "Create Date";
            this.lblOrigDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(8, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(265, 17);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Snippet Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmView
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(655, 458);
            this.ControlBox = false;
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPhoneEmail);
            this.Controls.Add(this.lblPhoneEmail);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDateUpdated);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblKeywords);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.lblOrigDate);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View Code Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmView_FormClosing);
            this.Load += new System.EventHandler(this.FrmView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnCopy;
        internal System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.TextBox txtPhoneEmail;
        public System.Windows.Forms.Label lblPhoneEmail;
        public System.Windows.Forms.Label lblAuthor;
        public System.Windows.Forms.TextBox txtKeywords;
        public System.Windows.Forms.TextBox txtLanguage;
        public System.Windows.Forms.TextBox txtPurpose;
        public System.Windows.Forms.TextBox txtVersion;
        public System.Windows.Forms.TextBox txtDateCreated;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtDateUpdated;
        public System.Windows.Forms.Label lblCode;
        public System.Windows.Forms.Label lblKeywords;
        public System.Windows.Forms.Label lblPurpose;
        public System.Windows.Forms.Label lblLanguage;
        public System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.Label lblUpdateDate;
        public System.Windows.Forms.Label lblOrigDate;
        public System.Windows.Forms.Label lblTitle;
    }
}