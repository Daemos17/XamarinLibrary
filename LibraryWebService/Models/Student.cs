using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryWebService.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }
        public int IdPersStudFk { get; set; }
        public int IdGroupFk { get; set; }
        public string Year { get; set; }

        public virtual Group IdGroupFkNavigation { get; set; }
        public virtual Person IdPersStudFkNavigation { get; set; }
    }
}
