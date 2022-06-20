using System;
using System.Collections.Generic;
using System.Text;

namespace MobileLibrary.Models
{
    public partial class Maker
    {
        public Maker()
        {

            this.Books = new HashSet<Book>();

        }


        public int Id_maker { get; set; }

        public string MakerName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}
