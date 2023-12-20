using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Textbook : ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public string Subject { get; set; }

        public string GetBookType()
        {
            return "Textbook";
        }
    }

}
