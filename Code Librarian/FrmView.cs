/**
 * This file is part of Code Librarian <https://github.com/StevenJDH/Code-Librarian>.
 * Copyright (C) 2019 Steven Jenkins De Haro.
 *
 * Code Librarian is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Code Librarian is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Code Librarian.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
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
        private readonly string _selectedLanguage;

        public FrmView(IUnitOfWork unitOfWork, string snippetTitle, string language)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            _selectedTitle = snippetTitle;
            _selectedLanguage = language;
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            var snippet = _unitOfWork.Snippets.GetSnippetsWithAll()
                .FirstOrDefault(s => s.Title == _selectedTitle && s.Language.Name == _selectedLanguage);

            if (snippet == null)
            {
                throw new InvalidOperationException($"The snippet record '{_selectedTitle}' was not found.");
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
            txtCode.Text = snippet.CodeSnippet;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCode.Text);
            MessageBox.Show("The code snippet was copied to clipboard successfully.",
                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
