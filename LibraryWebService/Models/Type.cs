using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryWebService.Models
{
    public partial class Type
    {
        public Type()
        {
            Books = new HashSet<Book>();
        }

        public int IdType { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
