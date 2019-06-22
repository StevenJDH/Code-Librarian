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
    public class Snippet
    {
        public int SnippetId { get; set; }

        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        [Index("ix_snippet_title_language", 1, IsUnique = true)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Purpose { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DateUpdated { get; set; }

        [Required]
        [StringLength(5)]
        public string Version { get; set; }

        [Required]
        [ForeignKey("Language")]
        [Index("ix_snippet_title_language", 2, IsUnique = true)]
        public int LanguageId { get; set; }

        [Required]
        [StringLength(255)]
        public string Keywords { get; set; }

        [Required]
        [StringLength(60000)]
        public string CodeSnippet { get; set; }

        [InverseProperty("Snippets")]
        public Author Author { get; set; }

        [InverseProperty("Snippets")]
        public Language Language { get; set; }
    }
}
