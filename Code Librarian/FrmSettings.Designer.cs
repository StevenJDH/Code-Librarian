namespace Code_Librarian
{
    partial class FrmSettings
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.fraList = new System.Windows.Forms.GroupBox();
            this.optRight = new System.Windows.Forms.RadioButton();
            this.optLeft = new System.Windows.Forms.RadioButton();
            this.fraList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(104, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // fraList
            // 
            this.fraList.BackColor = System.Drawing.SystemColors.Control;
            this.fraList.Controls.Add(this.optRight);
            this.fraList.Controls.Add(this.optLeft);
            this.fraList.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraList.ForeColor = System.Drawing.Color.Black;
            this.fraList.Location = new System.Drawing.Point(8, 8);
            this.fraList.Name = "fraList";
            this.fraList.Padding = new System.Windows.Forms.Padding(0);
            this.fraList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraList.Size = new System.Drawing.Size(177, 81);
            this.fraList.TabIndex = 12;
            this.fraList.TabStop = false;
            this.fraList.Text = "List Placement";
            // 
            // optRight
            // 
            this.optRight.BackColor = System.Drawing.SystemColors.Control;
            this.optRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.optRight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRight.ForeColor = System.Drawing.Color.Black;
            this.optRight.Location = new System.Drawing.Point(8, 48);
            this.optRight.Name = "optRight";
            this.optRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optRight.Size = new System.Drawing.Size(161, 17);
            this.optRight.TabIndex = 3;
            this.optRight.TabStop = true;
            this.optRight.Text = "Align List to Right";
            this.optRight.UseVisualStyleBackColor = false;
            // 
            // optLeft
            // 
            this.optLeft.BackColor = System.Drawing.SystemColors.Control;
            this.optLeft.Checked = true;
            this.optLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.optLeft.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLeft.ForeColor = System.Drawing.Color.Black;
            this.optLeft.Location = new System.Drawing.Point(8, 24);
            this.optLeft.Name = "optLeft";
            this.optLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optLeft.Size = new System.Drawing.Size(161, 17);
            this.optLeft.TabIndex = 2;
            this.optLeft.TabStop = true;
            this.optLeft.Text = "Align List to Left";
            this.optLeft.UseVisualStyleBackColor = false;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 129);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.fraList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.fraList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.GroupBox fraList;
        public System.Windows.Forms.RadioButton optRight;
        public System.Windows.Forms.RadioButton optLeft;
    }
}