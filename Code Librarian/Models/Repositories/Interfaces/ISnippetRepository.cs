using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Librarian.Models.Repositories.Interfaces
{
    public interface ISnippetRepository : IRepository<Snippet>
    {
        /// <summary>
        /// Gets a flat collection of Snippets with eager-loaded navigation properties for
        /// Authors and Languages with the returned snippet information.
        /// </summary>
        /// <returns>All snippets and all navigation properties.</returns>
        IEnumerable<Snippet> GetSnippetsWithAll();
    }
}
