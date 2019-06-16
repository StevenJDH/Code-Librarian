using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Librarian.Models
{
    public class Language
    {
        public Language()
        {
            Snippets = new HashSet<Snippet>();
        }

        public int LanguageId { get; set; }

        [Required]
        [StringLength(30)]
        [Index("ix_language_name", IsUnique = true)]
        public string Name { get; set; }

        [InverseProperty("Language")]
        public ICollection<Snippet> Snippets { get; set; }
    }
}
