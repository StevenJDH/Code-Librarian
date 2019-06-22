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

namespace Code_Librarian.Classes
{
    sealed class AppConfiguration
    {
        private readonly string _configPath;

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
                MessageBox.Show($"{ex.GetType().Name}: {ex.Message}",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        public static AppConfiguration Instance { get; } = new AppConfiguration();

        /// <summary>
        /// Gets the database path from '%AppData%/ASC-C/Code Librarian' in the current user's profile.
        /// </summary>
        /// <returns>Path to database</returns>
        public string GetDbPath() => Path.Combine(_configPath, "CodeLib.sqlite3");

        /// <summary>
        /// Gets the path where the configuration needs to be stored for the current user.
        /// </summary>
        /// <returns>Configuration folder path</returns>
        public string GetConfigPath() => _configPath;

        /// <summary>
        /// Sets up the personal database and loads any settings used by the application in general once implemented.
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
        }
    }
}
