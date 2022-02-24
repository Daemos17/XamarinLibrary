using System;
using System.Collections.Generic;



namespace LibraryWebService.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        public int IdGenre { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
