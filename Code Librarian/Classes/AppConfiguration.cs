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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Code_Librarian.Classes
{
    sealed class AppConfiguration
    {
        private readonly string _configPath;
        private string _guestDbPath;
        private static readonly XNamespace Nspace = "https://github.com/StevenJDH/Code-Librarian";

        private AppConfiguration()
        {
            _configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ASC-C", "Code Librarian");
            try
            {
                LoadSettings();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        public static AppConfiguration Instance { get; } = new AppConfiguration();
        public DockStyle ListPanelAlignment { get; set; }

        /// <summary>
        /// Gets the database path from '%AppData%/ASC-C/Code Librarian' in the current user's profile,
        /// unless a guest database path is set.
        /// </summary>
        /// <returns>Path to database</returns>
        public string GetDbPath() => _guestDbPath ?? Path.Combine(_configPath, "CodeLib.sqlite3");

        /// <summary>
        /// Gets the configuration path from '%AppData%/ASC-C/Code Librarian' in the current user's profile.
        /// </summary>
        /// <returns>Path to configuration</returns>
        public string GetConfigPath() => Path.Combine(_configPath, "Code-Librarian-Config.xml");

        /// <summary>
        /// Sets the temporary guest database path that will override the path to the current user's
        /// database. Use <see langword="null" /> to revert back to the current user's database.
        /// </summary>
        /// <param name="path">Path to guest database, or null to use current user's database.</param>
        public void SetGuestDbPath(string path) => _guestDbPath = path;

        /// <summary>
        /// Sets up the personal database and loads any settings used by the application in general.
        /// </summary>
        private void LoadSettings()
        {
            if (File.Exists(GetDbPath()) == false)
            {
                MessageBox.Show("Code Librarian needs to set up your personal database as it could not find one already in place.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Directory.CreateDirectory(_configPath); // Builds any missing folders in path.
                File.WriteAllBytes(GetDbPath(), Properties.Resources.CodeLib);

                MessageBox.Show("All done! You are now ready to start using the program.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (File.Exists(GetConfigPath()))
            {
                var xmlConfig = XElement.Load(GetConfigPath(), LoadOptions.None);

                ListPanelAlignment = int.Parse(xmlConfig.Element(Nspace + "ListPanelAlignment")?.Value ?? "0") == 0 ?
                    DockStyle.Left : DockStyle.Right;
            }
            else
            {
                ListPanelAlignment = DockStyle.Left;
                Save();
            }
        }

        /// <summary>
        /// Saves the current configuration state of the application.
        /// </summary>
        public void Save()
        {
            var xmlTree = new XElement(Nspace + "Root",
                new XElement(Nspace + "ListPanelAlignment", ListPanelAlignment == DockStyle.Left ? 0 : 1)
            );
            xmlTree.Save(GetConfigPath(), SaveOptions.None);
        }
    }
}
