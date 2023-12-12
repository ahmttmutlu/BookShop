using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Library : BaseModel
    {
        public string LibraryAddress { get; set; }
        public string LibraryPhoneNumber { get; set; }
        public bool IsOpen { get; set; }
        public bool IsClosed { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Shelf> Shelfs { get; set; }


    }
}
