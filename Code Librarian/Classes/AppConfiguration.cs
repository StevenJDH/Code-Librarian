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
