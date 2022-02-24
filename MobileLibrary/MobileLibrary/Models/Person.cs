using System;
using System.Collections.Generic;



namespace LibraryWebService.Models
{
    public partial class Person
    {
        public Person()
        {
            Students = new HashSet<Student>();
            Workers = new HashSet<Worker>();
        }

        public int IdPerson { get; set; }
        public string FullName { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
