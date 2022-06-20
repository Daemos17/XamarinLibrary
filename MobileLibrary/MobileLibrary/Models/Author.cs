using System;
using System.Collections.Generic;
using System.Text;

namespace MobileLibrary.Models
{
    public partial class Author
    {
        public Author()
        {

            this.Books = new HashSet<Book>();

        }


        public int Id { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }


        public virtual ICollection<Book> Books { get; set; }


    }
}
