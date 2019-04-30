using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Organizer
    {
        public virtual int OrganizerId { get; set; }
        public virtual string OrganizerName { get; set; }
        public virtual string Email { get; set; }
        public virtual List<Events> Event { get; set; }
    }
}