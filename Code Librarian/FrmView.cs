﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Librarian.Models.UnitOfWork;

namespace Code_Librarian
{
    public partial class FrmView : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _selectedTitle;

        public FrmView(IUnitOfWork unitOfWork, string snippetTitle)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _selectedTitle = snippetTitle;
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            var snippet = _unitOfWork.Snippets.GetSnippetsWithAll()
                .FirstOrDefault(s => s.Title == _selectedTitle);

            if (snippet == null)
            {
                // TODO: prompt maybe with a message.
                return;
            }

            txtAuthor.Text = snippet.Author.Name;
            txtPhone.Text = snippet.Author.PhoneNumber;
            txtTitle.Text = snippet.Title;
            txtDateCreated.Text = snippet.DateCreated.ToShortDateString();
            txtDateUpdated.Text = snippet.DateUpdated.ToShortDateString();
            txtVersion.Text = snippet.Version;
            txtLanguage.Text = snippet.Language.Name;
            txtPurpose.Text = snippet.Purpose;
            txtKeywords.Text = snippet.Keywords;
            rtfCode.Text = snippet.CodeSnippet;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtfCode.Text);
            MessageBox.Show("The code snippet was copied to clipboard successfully.",
                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
