using System;
using System.Collections.Generic;



namespace MobileLibrary.Models
{
    public partial class Worker
    {
        public int IdWorker { get; set; }
        public int IdPersWorkFk { get; set; }
        public string Position { get; set; }

        public virtual Person IdPersWorkFkNavigation { get; set; }
    }
}
