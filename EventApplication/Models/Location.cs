using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Location
    {
        public virtual int LocationId { get; set; }
        public virtual string LocationName { get; set; }
        public virtual string Email { get; set; }
        public virtual List<Events> Event { get; set; }
    }
}