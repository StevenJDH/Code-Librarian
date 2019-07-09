namespace Code_Librarian
{
    partial class FrmManageAuthors
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhoneEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstViewAuthors = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPhoneEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(296, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 25);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(296, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 25);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(296, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 25);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(296, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 25);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtPhoneEmail
            // 
            this.txtPhoneEmail.AcceptsReturn = true;
            this.txtPhoneEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhoneEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneEmail.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneEmail.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneEmail.Location = new System.Drawing.Point(148, 108);
            this.txtPhoneEmail.MaxLength = 254;
            this.txtPhoneEmail.Name = "txtPhoneEmail";
            this.txtPhoneEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneEmail.Size = new System.Drawing.Size(141, 20);
            this.txtPhoneEmail.TabIndex = 13;
            this.txtPhoneEmail.TextChanged += new System.EventHandler(this.TxtPhoneEmail_TextChanged);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(8, 108);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // lstViewAuthors
            // 
            this.lstViewAuthors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewAuthors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmPhoneEmail});
            this.lstViewAuthors.FullRowSelect = true;
            this.lstViewAuthors.GridLines = true;
            this.lstViewAuthors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewAuthors.HideSelection = false;
            this.lstViewAuthors.Location = new System.Drawing.Point(8, 8);
            this.lstViewAuthors.MultiSelect = false;
            this.lstViewAuthors.Name = "lstViewAuthors";
            this.lstViewAuthors.Size = new System.Drawing.Size(280, 88);
            this.lstViewAuthors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstViewAuthors.TabIndex = 20;
            this.lstViewAuthors.UseCompatibleStateImageBehavior = false;
            this.lstViewAuthors.View = System.Windows.Forms.View.Details;
            this.lstViewAuthors.SelectedIndexChanged += new System.EventHandler(this.LstViewAuthors_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 140;
            // 
            // clmPhoneEmail
            // 
            this.clmPhoneEmail.Text = "Phone Number/Email";
            this.clmPhoneEmail.Width = 140;
            // 
            // FrmManageAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 137);
            this.ControlBox = false;
            this.Controls.Add(this.lstViewAuthors);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhoneEmail);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageAuthors";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Authors";
            this.Load += new System.EventHandler(this.FrmManageAuthors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtPhoneEmail;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView lstViewAuthors;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmPhoneEmail;
    }
}