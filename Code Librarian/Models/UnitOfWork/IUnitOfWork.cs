using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Models.Repositories.Interfaces;

namespace Code_Librarian.Models.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        ILanguageRepository Languages { get; }
        ISnippetRepository Snippets { get; }
        bool IsDisposed { get; }

        void EditRecord<TEntity>(TEntity entity, Expression<Func<TEntity, string>> predicate)
            where TEntity : class;

        void UndoChanges();

        int Complete();
    }
}
