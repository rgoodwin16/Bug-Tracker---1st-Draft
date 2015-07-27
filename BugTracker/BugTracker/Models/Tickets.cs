using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class Tickets
    {
        public int id { get; set; }
        public string Title {get; set;}
        public string Description {get; set;}
        public System.DateTimeOffset Created { get; set; }
        public Nullable<System.DateTimeOffset> Updated { get; set; }


    }
}