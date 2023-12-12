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
        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Author> Authors { get; set; }      
        public virtual Shelf Shelf { get; set; }








    }
}
