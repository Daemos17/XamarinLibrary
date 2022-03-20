using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryWebService.Models
{
    public partial class Book
    {
        public int IdBook { get; set; }
        public int IdAuthorFk { get; set; }
        public string Year { get; set; }
        public int? Amount { get; set; }
        public int? IdTypeFk { get; set; }
        public byte[] ImageCode { get; set; }
        public int? IdGenreFk { get; set; }
        public string Bookname { get; set; }

        public virtual Author IdAuthorFkNavigation { get; set; }
        public virtual Genre IdGenreFkNavigation { get; set; }
        public virtual Type IdTypeFkNavigation { get; set; }
    }
}
