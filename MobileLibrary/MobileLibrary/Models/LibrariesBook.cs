using System;
using System.Collections.Generic;



namespace MobileLibrary.Models
{
    public partial class LibrariesBook
    {
        public int? IdLibraryFk { get; set; }
        public int? IdBookLbFk { get; set; }
        public int? Amount { get; set; }

        public virtual Book IdBookLbFkNavigation { get; set; }
        public virtual Library IdLibraryFkNavigation { get; set; }
    }
}
