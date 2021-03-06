using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryWebService.Models
{
    public partial class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int IdGroup { get; set; }
        public string GroupName { get; set; }
        public string GroupAlias { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
