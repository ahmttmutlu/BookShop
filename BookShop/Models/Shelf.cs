using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Shelf : BaseModel
    {
        public int ShelfNumber {  get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
