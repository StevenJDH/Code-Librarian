using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Models.Repositories.Interfaces;

namespace Code_Librarian.Models.Repositories
{
    public sealed class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        private readonly AppDbContext _context;

        public LanguageRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
