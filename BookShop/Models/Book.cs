using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Book : BaseModel
    {

        public int PageCount { get; set; } = 0;
        public string? ISBN { get; set; } //kitap barkodu
        public bool IsDigital { get; set; }=false;
        public DateTime YearOfPublication { get; set; }
        public string? IMG { get; set; }
        public ICollection<Publisher> Publisher { get; set; }=new List<Publisher>();
        public ICollection<Category> Categories { get; set; }= new List<Category>();
        public ICollection<Author> Authors { get; set; } = new List<Author>();
        public ICollection<BookType> BookTypes { get; set; } = new List<BookType>();
        public virtual Shelf Shelf { get; set; }








    }
}
