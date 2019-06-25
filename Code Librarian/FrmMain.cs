﻿/**
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
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Librarian.Classes;
using Code_Librarian.Models;
using Code_Librarian.Models.UnitOfWork;

namespace Code_Librarian
{
    public partial class FrmMain : Form
    {
        private IUnitOfWork _unitOfWork;
        private const int WS_EX_COMPOSITED = 0x02000000;

        public FrmMain()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new AppDbContext());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Alpha_Background;
            TmrDateTime_Tick(this, EventArgs.Empty);
            int count = _unitOfWork.Snippets.GetAll().Count();
            toolStripInfo.Text = $"There are currently {count} snippet {(count == 1 ? "record" : "records")} in the database.";

            cmbLanguageFilter.Items.Add("--- Select Language ---");

            _unitOfWork.Languages.GetAll()
                .OrderBy(l => l.Name)
                .Select(l => l.Name)
                .ToList()
                .ForEach(l => cmbLanguageFilter.Items.Add(l));

            // Triggers the CmbLanguageFilter_SelectedIndexChanged event.
            cmbLanguageFilter.SelectedIndex = 0;
        }

        private void TmrDateTime_Tick(object sender, EventArgs e)
        {
            toolStripTime.Text = DateTime.Now.ToLongTimeString();
            toolStripDate.Text = DateTime.Now.ToShortDateString();
        }

        private void CmbLanguageFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterList();
        }

        /// <summary>
        /// Filters the snippet list based on the selected language chosen.
        /// </summary>
        private void FilterList()
        {
            lstSnippets.Items.Clear();

            if (cmbLanguageFilter.Text == "--- Select Language ---")
            {
                return;
            }

            _unitOfWork.Snippets.GetSnippetsWithAll()
                .Where(s => s.Language.Name == cmbLanguageFilter.Text)
                .Select(s => s.Title)
                .ToList()
                .ForEach(t => lstSnippets.Items.Add(t));
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }

        private void ToolStripRefresh_Click(object sender, EventArgs e)
        {
            BtnRefresh_Click(this, EventArgs.Empty);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (lstSnippets.Text == "")
            {
                return;
            }

            ShowChildWindow(new FrmView(_unitOfWork, lstSnippets.Text, cmbLanguageFilter.Text));
        }

        private void ShowChildWindow(Form mdiChild)
        {
            this.ActiveMdiChild?.Close();

            mdiChild.MdiParent = this;
            mdiChild.Dock = DockStyle.Fill;
            mdiChild.Show();
        }

        /// <summary>
        /// Fixes MDI child flickering when a form is displayed. This method essentially
        /// sets DoubledBuffered at the form level rather than at the control level.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;

                return cp;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _unitOfWork?.Dispose();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lstSnippets.Text == "")
            {
                return;
            }

            ShowChildWindow(new FrmEdit(_unitOfWork, lstSnippets.Text, cmbLanguageFilter.Text));
        }

        private void MnuDeleteRecord_Click(object sender, EventArgs e)
        {
            if (lstSnippets.Text == "")
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected record from the library?",
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var snippetRecord = _unitOfWork.Snippets
                .FirstOrDefault(s => s.Title == lstSnippets.Text && 
                                     s.Language.Name == cmbLanguageFilter.Text);
            _unitOfWork.Snippets.Remove(snippetRecord);

            try
            {
                _unitOfWork.Complete();
                MessageBox.Show("The record has been deleted successfully.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstSnippets.Items.Remove(lstSnippets.Text);
            }
            catch (DbUpdateException ex)
            {
                _unitOfWork.UndoChanges();
                MessageBox.Show($"Error: {ex.Message}", 
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripDeleteRecord_Click(object sender, EventArgs e)
        {
            MnuDeleteRecord_Click(this, EventArgs.Empty);
        }

        private void MnuAddNewRecord_Click(object sender, EventArgs e)
        {
            ShowChildWindow(new FrmAdd(_unitOfWork));
        }

        private void ToolStripAddNewRecord_Click(object sender, EventArgs e)
        {
            MnuAddNewRecord_Click(this, EventArgs.Empty);
        }

        private void LstSnippets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnView_Click(this, EventArgs.Empty);
            }
        }

        private void LstSnippets_DoubleClick(object sender, EventArgs e)
        {
            BtnView_Click(this, EventArgs.Empty);
        }

        private void MnuDonate_Click(object sender, EventArgs e)
        {
            try
            {
                // Sends URL to the operating system for opening.
                Process.Start("https://www.paypal.me/stevenjdh/5");
            }
            catch (Exception)
            {
                // Consuming exceptions
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void ToolStripAbout_Click(object sender, EventArgs e)
        {
            MnuAbout_Click(this, EventArgs.Empty);
        }

        private void MnuManageLanguages_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmManageLanguages(_unitOfWork))
            {
                frm.ShowDialog();
            }
        }

        private void ToolStripManageLanguages_Click(object sender, EventArgs e)
        {
            MnuManageLanguages_Click(this, EventArgs.Empty);
        }

        private void MnuManageAuthors_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmManageAuthors(_unitOfWork))
            {
                frm.ShowDialog();
            }
        }

        private void ToolStripManageAuthors_Click(object sender, EventArgs e)
        {
            MnuManageAuthors_Click(this, EventArgs.Empty);
        }

        private void MnuSearch_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmSearch(_unitOfWork))
            {
                frm.SearchResultViewSelected += FrmSearch_SearchResultViewSelected;
                frm.SearchResultEditSelected += FrmSearch_SearchResultEditSelected;
                frm.ShowDialog();
            }
        }

        private void FrmSearch_SearchResultViewSelected(object sender, SearchResultEventArgs e)
        {
            ShowChildWindow(new FrmView(_unitOfWork, e.Title, e.Language));
        }

        private void FrmSearch_SearchResultEditSelected(object sender, SearchResultEventArgs e)
        {
            ShowChildWindow(new FrmEdit(_unitOfWork, e.Title, e.Language));
        }
        
        private void ToolStripSearch_Click(object sender, EventArgs e)
        {
            MnuSearch_Click(this, EventArgs.Empty);
        }

        private void MnuSettings_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmSettings(pnlDock))
            {
                frm.ShowDialog();
            }
        }

        private void ToolStripSettings_Click(object sender, EventArgs e)
        {
            MnuSettings_Click(this, EventArgs.Empty);
        }

        private void MnuCreateBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to backup your personal database?", 
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            fbDialog.SelectedPath = AppConfiguration.Instance.GetConfigPath();

            if (fbDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string backup = Path.Combine(fbDialog.SelectedPath, 
                $"CodeLib_{DateTime.Now.ToString("yyyy-MM-dd_HHmmss")}.sqlite3");

            try
            {
                File.Copy(AppConfiguration.Instance.GetDbPath(), backup, overwrite: false);
                MessageBox.Show("Your personal database has been backed up successfully.", 
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show($"{ex.GetType().Name}: {ex.Message}",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripCreateBackup_Click(object sender, EventArgs e)
        {
            MnuCreateBackup_Click(this, EventArgs.Empty);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuOpenDatabase_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild?.Close();
            _unitOfWork?.Dispose();

            openFileDialog.Filter = "Code Librarian Database (*.sqlite3)|*.sqlite3";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                AppConfiguration.Instance.SetGuestDbPath(openFileDialog.FileName);
                _unitOfWork = new UnitOfWork(new AppDbContext());
                cmbLanguageFilter.SelectedIndex = 0;

                mnuOpenDatabase.Visible = false;
                toolStripOpenDatabase.Enabled = false;
                mnuCloseDatabase.Visible = true;

                // Quick test to check if database can be queried.
                _unitOfWork.Authors.GetAll();

                MessageBox.Show($"The '{Path.GetFileNameWithoutExtension(openFileDialog.FileName)}' database is now connected.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: The selected database is invalid or not compatible.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                MnuCloseDatabase_Click(this, EventArgs.Empty);
            }
        }

        private void ToolStripOpenDatabase_Click(object sender, EventArgs e)
        {
            MnuOpenDatabase_Click(this, EventArgs.Empty);
        }

        private void MnuCloseDatabase_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild?.Close();
            _unitOfWork?.Dispose();
            AppConfiguration.Instance.SetGuestDbPath(null);
            _unitOfWork = new UnitOfWork(new AppDbContext());
            cmbLanguageFilter.SelectedIndex = 0;

            mnuCloseDatabase.Visible = false;
            mnuOpenDatabase.Visible = true;
            toolStripOpenDatabase.Enabled = true;

            MessageBox.Show("Your personal database has been reconnected.",
                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
