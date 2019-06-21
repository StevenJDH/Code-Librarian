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
        public static IQueryable<T> OptionalWhere<T>(this IQueryable<T> query, Expression<Func<T, bool>> predicate, bool executeFilter)
        {
            return executeFilter == false ? query : query.Where(predicate);
        }
    }
}
