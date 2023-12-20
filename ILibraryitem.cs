using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface ILibraryItem
    {
        string Title { get; set; }
        string Author { get; set; }
        int YearPublished { get; set; }
        string GetBookType();
    }

}
