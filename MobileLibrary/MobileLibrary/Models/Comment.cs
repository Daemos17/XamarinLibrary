using System;
using System.Collections.Generic;



namespace MobileLibrary.Models
{
    public partial class Comment
    {
        public int IdComment { get; set; }
        public int? IdStudentCom { get; set; }
        public int? IdBookCom { get; set; }
        public string Commnet { get; set; }

        public virtual Book IdBookComNavigation { get; set; }
        public virtual Student IdStudentComNavigation { get; set; }
    }
}
