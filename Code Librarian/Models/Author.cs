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
        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [InverseProperty("Author")]
        public ICollection<Snippet> Snippets { get; set; }
    }
}
