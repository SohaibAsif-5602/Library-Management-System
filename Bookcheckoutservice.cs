using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class BookCheckoutService
    {
        public void CheckOutBook(ILibraryItem item)
        {
            Console.WriteLine($"Checking out {item.GetBookType()}: {item.Title}");
            // Implement the checkout logic here
        }
    }

}
