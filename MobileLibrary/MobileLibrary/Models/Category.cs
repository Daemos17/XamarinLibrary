using System;
using System.Collections.Generic;
using System.Text;

namespace MobileLibrary.Models
{
    public partial class Category
    {
        public Category()
        {

            this.Books = new HashSet<Book>();

        }


        public int Id_category { get; set; }

        public string CategoryName { get; set; }


        public virtual ICollection<Book> Books { get; set; }


    }
}
