using System;
using System.Collections.Generic;



namespace MobileLibrary.Models
{
    public partial class Book
    {
        public Book()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
       
        public string BookName { get; set; }
        public string Year { get; set; }
        public int? Amount { get; set; }
        public int? IdTypeFk { get; set; }
        public string ImagePath { get; set; }
        public int? IdGenreFk { get; set; }

        public virtual Author IdAuthorFkNavigation { get; set; }
        public virtual Genre IdGenreFkNavigation { get; set; }
        public virtual Type IdTypeFkNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
