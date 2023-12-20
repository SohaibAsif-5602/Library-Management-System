using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface ILibraryOperations
    {
        void AddItem(ILibraryItem item);
        void RemoveItem(ILibraryItem item);
        ILibraryItem GetItemByTitle(string title);
        void ListItems();
    }

}
