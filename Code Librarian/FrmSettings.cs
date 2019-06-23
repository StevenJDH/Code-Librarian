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

namespace Code_Librarian
{
    public partial class FrmSettings : Form
    {
        private readonly Panel _panel;

        public FrmSettings(Panel panel)
        {
            InitializeComponent();

            _panel = panel;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            optRight.Checked = (_panel.Dock == DockStyle.Right);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _panel.Dock = optLeft.Checked ? DockStyle.Left : DockStyle.Right;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
