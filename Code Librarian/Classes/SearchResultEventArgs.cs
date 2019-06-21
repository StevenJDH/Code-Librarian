using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Librarian.Classes
{
    /// <summary>
    /// Contains event data for the selected search result.
    /// </summary>
    public class SearchResultEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Language { get; set; }
    }
}
