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
        [StringLength(32768)]
        public string CodeSnippet { get; set; }

        [InverseProperty("Snippets")]
        public Author Author { get; set; }

        [InverseProperty("Snippets")]
        public Language Language { get; set; }
    }
}
