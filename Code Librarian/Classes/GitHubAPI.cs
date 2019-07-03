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
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Code_Librarian.Classes
{
    class GitHubAPI
    {
        /// <summary>
        /// Gets the latest release or prerelease from the provided GitHub repository.
        /// </summary>
        /// <remarks>
        /// The 'releases/latest' endpoint omits prereleases so the endpoint below is a more flexible option.
        /// </remarks>
        /// <param name="owner">Owner of the repo</param>
        /// <param name="repo">Name of the repo to check</param>
        /// <param name="prerelease">Optionally set to false to exclude prereleases</param>
        /// <returns>Response with release details</returns>
        public async Task<GitHubLatestReleaseResponse> GetLatestVersionAsync(string owner, string repo, bool prerelease = true)
        {
            string url = $"https://api.github.com/repos/{owner.Trim()}/{repo.Trim()}/releases";
            var release = await APIServiceCallAsync<IEnumerable<GitHubLatestReleaseResponse>>(url);

            if (prerelease)
            {
                return release.FirstOrDefault();
            }
            return release.FirstOrDefault(r => r.IsPrerelease == false);
        }

        /// <summary>
        /// Calls the provided GitHub API endpoint and returns the deserialized response.
        /// </summary>
        /// <remarks>
        /// GitHub requires a valid User-Agent header with all API request or you will get a HTTP 403 Forbidden
        /// status code.
        /// See <a href="https://developer.github.com/v3/#user-agent-required">User agent required</a> for details.
        /// </remarks>
        /// <typeparam name="T">The type of response expected by the endpoint</typeparam>
        /// <param name="apiLink">The URL link for the API endpoint</param>
        /// <returns>API response of the endpoint used</returns>
        private async Task<T> APIServiceCallAsync<T>(string apiLink)
        {
            string userAgentFirefox = "Mozilla/5.0 (Windows NT 10.0; rv:67.0) Gecko/20100101 Firefox/67.0";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", userAgentFirefox);
                client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json"); // Recommended by GitHub.

                using (HttpResponseMessage response = await client.GetAsync(apiLink))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<T>(jsonData);
                    }
                    throw new HttpRequestException($"Request failed with HTTP status code {(int)response.StatusCode} - {response.ReasonPhrase}.");
                }
            }
        }
    }
}
