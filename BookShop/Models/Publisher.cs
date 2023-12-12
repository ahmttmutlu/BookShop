using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Publisher : BaseModel
    {
        public int PhoneNumber { get; set; }
        public string Email   { get; set; }
        public string Address { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
