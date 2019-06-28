using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Code_Librarian.Classes
{
    /// <summary>
    /// Exception thrown from <see cref="System.Data.Entity.DbContext.SaveChanges"/> when validating entities fails.
    /// </summary>
    [Serializable]
    class EntityValidationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="DbEntityValidationException"/>.
        /// </summary>
        public EntityValidationException() : base() { }

        /// <summary>
        /// Initializes a new instance of <see cref="DbEntityValidationException"/>.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public EntityValidationException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of <see cref="DbEntityValidationException"/>.
        /// </summary>
        /// <param name="exception"> The thrown <see cref="DbEntityValidationException"/> exception.</param>
        public EntityValidationException(DbEntityValidationException exception) : base(ModifyMessage(exception)) { }

        /// <summary>
        /// Initializes a new instance of <see cref="DbEntityValidationException"/>.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="inner">The inner exception.</param>
        public EntityValidationException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Modifies the exception message from DbEntityValidationException to list the actual validation errors
        /// for an entity.
        /// </summary>
        /// <param name="exception">The exception that was thrown.</param>
        /// <returns>An exception message that also lists the validation errors.</returns>
        private static string ModifyMessage(DbEntityValidationException exception)
        {
            var sb = new StringBuilder("The following validation errors were encountered:\n\n");

            foreach (var val in exception.EntityValidationErrors.ElementAt(0).ValidationErrors)
            {
                sb.AppendLine($"- {val.PropertyName}: {val.ErrorMessage}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
