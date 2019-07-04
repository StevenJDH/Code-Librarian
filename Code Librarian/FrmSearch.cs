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
using Code_Librarian.Classes;
using Code_Librarian.Extensions;
using Code_Librarian.Models.UnitOfWork;

namespace Code_Librarian
{
    public partial class FrmSearch : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public event EventHandler<SearchResultEventArgs> SearchResultViewSelected;
        public event EventHandler<SearchResultEventArgs> SearchResultEditSelected;

        public FrmSearch(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            _unitOfWork.Languages.GetAll()
                .Select(l => l.Name)
                .ToList()
                .ForEach(l => cmbLanguages.Items.Add(l));

            _unitOfWork.Authors.GetAll()
                .Select(a => a.Name)
                .ToList()
                .ForEach(a => cmbAuthors.Items.Add(a));
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (chkKeywords.Checked && String.IsNullOrWhiteSpace(txtKeywords.Text))
            {
                MessageBox.Show("Please provide at least one keyword before searching.", 
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkLanguage.Checked && cmbLanguages.Text == "")
            {
                MessageBox.Show("Please select a language before searching.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkAuthor.Checked && cmbAuthors.Text == "")
            {
                MessageBox.Show("Please select an author before searching.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lstViewResults.Items.Clear();

            var keywords = txtKeywords.Text // TODO: make keyword comparison all lowercase.
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToHashSet();

            _unitOfWork.Snippets.GetSnippetsWithAll().AsQueryable()
                .OptionalWhere(s => s.Keywords.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(k => k.Trim())
                    .Intersect(keywords)
                    .Any(), chkKeywords.Checked)
                .OptionalWhere(s => s.Language.Name == cmbLanguages.Text, chkLanguage.Checked)
                .OptionalWhere(s => s.Author.Name == cmbAuthors.Text, chkAuthor.Checked)
                .ToList()
                .ForEach(s => lstViewResults.Items.Add(new ListViewItem(new[] { s.Title, s.Language.Name })));

            HideHorizontalScrollBar();
            Frame1.Text = $"Search results: {lstViewResults.Items.Count}";
        }

        /// <summary>
        /// Hides the horizontal scrollbar of the ListView control since there is no native
        /// way of doing it, and doing it via APIs do not seem to work anymore.
        /// </summary>
        private void HideHorizontalScrollBar()
        {
            int itemsCount = lstViewResults.Items.Count;

            if (lstViewResults.Items.Count == 0)
            {
                return;
            }

            int itemHeight = lstViewResults.Items[0].Bounds.Height;
            int visibleItem = lstViewResults.ClientRectangle.Height / itemHeight;

            if (itemsCount < visibleItem)
            {
                clmTitle.Width = lstViewResults.Size.Width;
            }
            else
            {
                clmTitle.Width -= SystemInformation.VerticalScrollBarWidth;
            }
        }

        private void MnuSearch_Click(object sender, EventArgs e)
        {
            BtnSearch_Click(this, EventArgs.Empty);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            BtnClose_Click(this, EventArgs.Empty);
        }

        private void ChkKeywords_CheckedChanged(object sender, EventArgs e)
        {
            txtKeywords.Enabled = chkKeywords.Checked;
        }

        private void ChkLanguage_CheckedChanged(object sender, EventArgs e)
        {
            cmbLanguages.Enabled = chkLanguage.Checked;
        }

        private void ChkAuthor_CheckedChanged(object sender, EventArgs e)
        {
            cmbAuthors.Enabled = chkAuthor.Checked;
        }

        protected virtual void OnSearchResultViewSelected(SearchResultEventArgs e)
        {
            EventHandler<SearchResultEventArgs> handler = SearchResultViewSelected;
            handler?.Invoke(this, e);
        }

        protected virtual void OnSearchResultEditSelected(SearchResultEventArgs e)
        {
            EventHandler<SearchResultEventArgs> handler = SearchResultEditSelected;
            handler?.Invoke(this, e);
        }

        private void MnuReset_Click(object sender, EventArgs e)
        {
            lstViewResults.Items.Clear();
            chkKeywords.Checked = true;
            chkLanguage.Checked = false;
            chkAuthor.Checked = false;
            txtKeywords.Text = "";
            txtKeywords.Focus();
            cmbLanguages.SelectedIndex = -1;
            cmbAuthors.SelectedIndex = -1;
            Frame1.Text = "Search results:";
        }

        private void MnuView_Click(object sender, EventArgs e)
        {
            if (lstViewResults.SelectedItems.Count == 0)
            {
                return;
            }

            var args = new SearchResultEventArgs()
            {
                Title = lstViewResults.SelectedItems[0].SubItems[clmTitle.Index].Text,
                Language = lstViewResults.SelectedItems[0].SubItems[clmLanguage.Index].Text
            };

            OnSearchResultViewSelected(args);
        }

        private void LstViewResults_DoubleClick(object sender, EventArgs e)
        {
            MnuView_Click(this, EventArgs.Empty);
        }

        private void MnuEdit_Click(object sender, EventArgs e)
        {
            if (lstViewResults.SelectedItems.Count == 0)
            {
                return;
            }

            var args = new SearchResultEventArgs()
            {
                Title = lstViewResults.SelectedItems[0].SubItems[clmTitle.Index].Text,
                Language = lstViewResults.SelectedItems[0].SubItems[clmLanguage.Index].Text
            };

            OnSearchResultEditSelected(args);
            this.Close();
        }
    }
}
