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

namespace Code_Librarian.Extensions
{
    /// <summary>
    /// Useful extensions to overcome some missing functionality and limitations while keeping the code clean.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Removes excess white space between and around characters, including tabs and new lines.
        /// </summary>
        /// <param name="str">The object where this extension will be attached.</param>
        /// <returns>Original string with excess white space removed.</returns>
        /// <exception cref="System.InvalidOperationException">String is null, empty, or consists only of white space characters.</exception>
        public static string RemoveExcessWhiteSpace(this string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                throw new InvalidOperationException(
                    "String is null, empty, or consists only of white space characters.");
            }

            return Regex.Replace(str, @"\s+", " ",
                RegexOptions.Singleline).Trim();
        }
    }
}