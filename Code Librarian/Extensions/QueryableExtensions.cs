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

namespace Code_Librarian.Extensions
{
    /// <summary>
    /// Useful extensions to overcome some missing functionality and limitations while keeping the code clean.
    /// </summary>
    public static class QueryableExtensions
    {
        /// <summary>
        /// Conditionally applies a Where clause to a <see cref="Queryable"/> object based
        /// on the state set for the <paramref name="executeFilter"/> parameter.
        /// </summary>
        /// <typeparam name="T">The <see cref="Queryable"/> object.</typeparam>
        /// <param name="query">The object where this extension will be attached.</param>
        /// <param name="predicate">Predicate to use as the Where clause's expression.</param>
        /// <param name="executeFilter">True to apply the Where clause, or false to not.</param>
        /// <returns></returns>
        public static IQueryable<T> OptionalWhere<T>(this IQueryable<T> query, Expression<Func<T, bool>> predicate, bool executeFilter)
        {
            return executeFilter == false ? query : query.Where(predicate);
        }
    }
}
