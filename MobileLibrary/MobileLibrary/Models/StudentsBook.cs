using System;
using System.Collections.Generic;



namespace LibraryWebService.Models
{
    public partial class StudentsBook
    {
        public int IdBookS { get; set; }
        public int IdStudentS { get; set; }
        public DateTime? DateofPicking { get; set; }
        public DateTime? DateofRetruning { get; set; }

        public virtual Book IdBookSNavigation { get; set; }
        public virtual Student IdStudentSNavigation { get; set; }
    }
}
