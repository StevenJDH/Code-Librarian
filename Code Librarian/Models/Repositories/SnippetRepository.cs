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
