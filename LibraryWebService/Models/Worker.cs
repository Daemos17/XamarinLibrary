using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryWebService.Models
{
    public partial class Worker
    {
        public int IdWorker { get; set; }
        public int IdPersWorkFk { get; set; }
        public string Position { get; set; }

        public virtual Person IdPersWorkFkNavigation { get; set; }
    }
}
