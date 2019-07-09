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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Librarian.Models
{
    public class Author
    {
        public Author()
        {
            Snippets = new HashSet<Snippet>();
        }

        public int AuthorId { get; set; }

        [Required]
        [StringLength(60)]
        [Index("ix_author_name", IsUnique = true)]
        public string Name { get; set; }

        [Required]
        [StringLength(254)]
        public string ContactInfo { get; set; }

        [InverseProperty("Author")]
        public ICollection<Snippet> Snippets { get; set; }
    }
}
