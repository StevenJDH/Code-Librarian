using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Librarian.Extensions
{
    /// <summary>
    /// Useful extensions to overcome some missing functionality and limitations while keeping the code clean.
    /// </summary>
    public static class ObjectCollectionExtensions
    {
        /// <summary>
        /// Determines if the specified item is located within the collection. A parameter specifies the culture, case, 
        /// and sort rules used in the determination. The default is OrdinalIgnoreCase.
        /// </summary>
        /// <param name="items">The object where this extension will be attached.</param>
        /// <param name="value">The string to compare to this instance.</param>
        /// <param name="comparisonType">One of the enumeration values that specifies how the strings will be compared.</param>
        /// <returns>True if equal, and false if not.</returns>
        public static bool ContainsEx(this ListBox.ObjectCollection items, string value, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            foreach (var item in items)
            {
                if (item.ToString().Equals(value, comparisonType))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines if the specified item is located within the collection. A parameter specifies the culture, case, 
        /// and sort rules used in the determination. The default is OrdinalIgnoreCase.
        /// </summary>
        /// <param name="items">The object where this extension will be attached.</param>
        /// <param name="value">The string to compare to this instance.</param>
        /// <param name="comparisonType">One of the enumeration values that specifies how the strings will be compared.</param>
        /// <returns>True if equal, and false if not.</returns>
        public static bool ContainsEx(this ComboBox.ObjectCollection items, string value, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            foreach (var item in items)
            {
                if (item.ToString().Equals(value, comparisonType))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
