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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Code_Librarian.Classes
{
    public sealed class GitHubLatestReleaseResponse
    {
        [JsonProperty("html_url")]
        public string ReleaseUrl { get; set; }

        [JsonProperty("tag_name")]
        public string VersionTag { get; set; }

        [JsonProperty("prerelease")]
        public bool IsPrerelease { get; set; }

        [JsonProperty("published_at")]
        public DateTime PublishedDateTime { get; set; }

        [JsonProperty("body")]
        public string ReleaseNotes { get; set; }

        [JsonProperty("assets")]
        public IEnumerable<ReleaseAsset> Assets { get; set; }

        public class ReleaseAsset
        {
            [JsonProperty("name")]
            public string FileName { get; set; }

            [JsonProperty("content_type")]
            public string ContentType { get; set; }

            [JsonProperty("size")]
            public uint FileSize { get; set; }

            [JsonProperty("browser_download_url")]
            public string DownloadUrl { get; set; }
        }

        /// <summary>
        /// Checks to see if the release version on GitHub is newer than the current version running.
        /// </summary>
        /// <remarks>
        /// A check is done to ensure that version numbers use a x.x.x.x format.
        /// </remarks>
        /// <returns>True if update available or false is not</returns>
        public bool IsUpdateAvailable()
        {
            if (Regex.IsMatch(VersionTag, @"(\d+)\.(\d+)\.(\d+)\.(\d+)") == false)
            {
                return false;
            }

            var gitVersion = new Version(VersionTag);
            var appVersion = new Version(Application.ProductVersion);

            // Be aware that 1.0.0 is less than (<) 1.0.0.0, they are NOT equal. Use four places on GitHub.
            switch (appVersion.CompareTo(gitVersion))
            {
                default:
                case 0: // Same as
                case 1: // later than
                    return false;
                case -1: // earlier than
                    return true;
            }
        }
    }
}
