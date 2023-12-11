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
        public string Location { get; set; }
        public ICollection<Author> Authors { get; set; }=new List<Author>();
        public ICollection<Book> Books { get; set; }=new List<Book>();
    }
}
