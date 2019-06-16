using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Models.Repositories;
using Code_Librarian.Models.Repositories.Interfaces;

namespace Code_Librarian.Models.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IAuthorRepository Authors { get; private set; }
        public ILanguageRepository Languages { get; private set; }
        public ISnippetRepository Snippets { get; private set; }
        public bool IsDisposed { get; private set; }


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            IsDisposed = false;
            Authors = new AuthorRepository(_context);
            Languages = new LanguageRepository(_context);
            Snippets = new SnippetRepository(_context);
        }

        public void EditRecord<TEntity>(TEntity entity, Expression<Func<TEntity, string>> predicate)
            where TEntity : class
        {
            _context.Entry(entity).Property(predicate).IsModified = true;
        }

        public void UndoChanges()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public int Complete() => _context.SaveChanges();

        public void Dispose()
        {
            _context.Dispose();
            IsDisposed = true;
        }
    }
}
