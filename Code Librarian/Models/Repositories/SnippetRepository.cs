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
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Models.Repositories.Interfaces;

namespace Code_Librarian.Models.Repositories
{
    public sealed class SnippetRepository : Repository<Snippet>, ISnippetRepository
    {
        private readonly AppDbContext _context;

        public SnippetRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Snippet> GetSnippetsWithAll()
        {
            // The Includes are to eager load the navigation properties.
            return _context.Snippets
                .Include(s => s.Author)
                .Include(s => s.Language)
                .OrderBy(s => s.Title)
                .ToList();
        }
    }
}
