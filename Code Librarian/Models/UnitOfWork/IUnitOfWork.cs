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
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Code_Librarian.Classes;
using Code_Librarian.Models.Repositories.Interfaces;

namespace Code_Librarian.Models.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        ILanguageRepository Languages { get; }
        ISnippetRepository Snippets { get; }
        bool IsDisposed { get; }

        event EventHandler<WorkCompletedEventArgs> WorkCompleted;

        void EditRecord<TEntity>(TEntity entity, Expression<Func<TEntity, string>> predicate)
            where TEntity : class;

        /// <summary>
        /// Tests to see if the database has the needed tables, and if not, throws an exception.
        /// </summary>
        /// <exception cref="T:System.Data.Entity.Core.EntityCommandExecutionException">The database is invalid.</exception>
        void TestDbCompatibility();

        void UndoChanges();

        int Complete();
    }
}
