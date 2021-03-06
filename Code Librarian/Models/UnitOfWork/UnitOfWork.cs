﻿/**
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
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Classes;
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

        public event EventHandler<WorkCompletedEventArgs> WorkCompleted;

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

        public void TestDbCompatibility()
        {
            try
            {
                // Pseudo ID searched to see if exception is thrown.
                _context.Authors.Find(0);
                _context.Languages.Find(0);
                _context.Snippets.Find(0);
            }
            catch (EntityCommandExecutionException)
            {
                throw new EntityCommandExecutionException("The database is invalid.");
            }
        }

        public int Complete()
        {
            var changedEntities = _context.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified ||
                            e.State == EntityState.Added ||
                            e.State == EntityState.Deleted)
                .Select(s => (Entity)Enum.Parse(typeof(Entity), s.Entity.GetType().Name))
                .Distinct()
                .ToList();

            var args = new WorkCompletedEventArgs()
            {
                EntitiesChanged = changedEntities,
                ChangesMade = changedEntities.Count()
            };

            try
            {
                var count = _context.SaveChanges();

                OnWorkCompleted(args);

                return count;
            }
            catch (DbEntityValidationException ex)
            {
                throw new EntityValidationException(ex);
            }
        }

        private void Dispose(bool disposing)
        {
            if (IsDisposed || !disposing)
            {
                return;
            }

            _context.Dispose();
            IsDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // For when not properly disposed, at least we have the more costly F-Reachable-Queue.
        ~UnitOfWork()
        {
            Dispose(false);
        }

        public void OnWorkCompleted(WorkCompletedEventArgs e)
        {
            EventHandler<WorkCompletedEventArgs> handler = WorkCompleted;
            handler?.Invoke(this, e);
        }
    }
}
