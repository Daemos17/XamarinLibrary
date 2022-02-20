using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryWebService.Models
{
    public partial class Library
    {
        public int IdLibrary { get; set; }
        public string Address { get; set; }
        public string LibraryName { get; set; }
    }
}
