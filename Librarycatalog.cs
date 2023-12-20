using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryCatalog : ILibraryOperations
    {
        private List<ILibraryItem> catalog = new List<ILibraryItem>();

        public void AddItem(ILibraryItem item)
        {
            catalog.Add(item);
        }

        public void RemoveItem(ILibraryItem item)
        {
            catalog.Remove(item);
        }

        public ILibraryItem GetItemByTitle(string title)
        {
            return catalog.FirstOrDefault(item => item.Title == title);
        }

        public void ListItems()
        {
            foreach (var item in catalog)
            {
                Console.WriteLine($"{item.GetBookType()}: {item.Title} by {item.Author} ({item.YearPublished})");
            }
        }
    }

}
