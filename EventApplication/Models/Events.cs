using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Events
    {
        public virtual int EventsId { get; set; }
        public virtual string EventName { get; set; }
        public virtual Location Location { get; set; }
        public virtual Organizer Organizer { get; set; }
        public virtual string EventDescription { get; set; }
    }
}