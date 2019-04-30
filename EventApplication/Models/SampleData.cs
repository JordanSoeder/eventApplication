using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseAlways<EventDb>
    {
        protected override void Seed(EventDb context)
        {
            var eventTypes = new List<EventType>
            {
                new EventType { Type = "Concert"},
                new EventType { Type = "Convention"},
                new EventType { Type = "FurMeet"},
                new EventType { Type = "Rave"},
                new EventType { Type = "Dance"},
                new EventType { Type = "Tabletop RPG Sessions"},
                new EventType { Type = "Group up"},
                new EventType { Type = "Movie Night"},
                new EventType { Type = "Theatrical Play"},
                new EventType { Type = "Ballet"},
                new EventType { Type = "Children's Event"},
                new EventType { Type = "Tea Party"},
                new EventType { Type = "Classic Car Show"},
                new EventType { Type = "Musical"},
                new EventType { Type = "Gathering"},
                new EventType { Type = "Resale"},
                new EventType { Type = "Movie Magic"}
            };
            new List<Event>
            {
                new Event { Title = "Playstation 2019", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Gaming convention.",
                            StartDate = DateTime.Parse("05/01/2019 9:00:00"),
                            EndDate = DateTime.Parse("05/06/2019 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Sony", OrganizationContactInfo = "Phone: 440-668-6994 (Jordan)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Playstation 2018", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Gaming convention.",
                            StartDate = DateTime.Parse("05/03/2018 9:00:00"),
                            EndDate = DateTime.Parse("05/06/2018 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Sony", OrganizationContactInfo = "Phone: 440-668-6994 (Jordan)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Playstation 2017", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Gaming convention.",
                            StartDate = DateTime.Parse("05/03/2017 9:00:00"),
                            EndDate = DateTime.Parse("05/06/2017 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Sony", OrganizationContactInfo = "Phone: 440-668-6994 (Jordan)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Con on the Cob 2016", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Gaming convention.",
                            StartDate = DateTime.Parse("05/03/2016 9:00:00"),
                            EndDate = DateTime.Parse("05/06/2016 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Sony", OrganizationContactInfo = "Phone: 440-668-6994 (Jordan)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "ComicCon 2019", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Comic convention.",
                            StartDate = DateTime.Parse("05/11/2019 9:00:00"),
                            EndDate = DateTime.Parse("05/13/2019 1:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "ComicCon", OrganizationContactInfo = "",
                            MaxTickets = 18000, AvailableTickets = 10000
                          },
                //events 6-10
                new Event { Title = "ComicCon 2018", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Comic convention.",
                            StartDate = DateTime.Parse("05/11/2018 9:00:00"),
                            EndDate = DateTime.Parse("05/13/2018 1:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "ComicCon", OrganizationContactInfo = "",
                            MaxTickets = 18000, AvailableTickets = 10000
                          },
                new Event { Title = "ComicCon 2017", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Comic convention.",
                            StartDate = DateTime.Parse("05/11/2017 9:00:00"),
                            EndDate = DateTime.Parse("05/13/2017 1:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "ComicCon", OrganizationContactInfo = "",
                            MaxTickets = 18000, AvailableTickets = 10000
                          },
                new Event { Title = "Skyrim  Members Welcome", EventType = eventTypes.Single(e => e.Type == "Tabletop RPG Sessions"),
                            Description = "Skyrim sessions to be held at local store. New members welcome only first meetup listed future sessions TBD during first session.",
                            StartDate = DateTime.Parse("12/11/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/11/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "ElderScrolls", OrganizationContactInfo = "",
                            MaxTickets = 8, AvailableTickets = 3
                          },
                new Event { Title = "Last Minute Deal Test 01 ", EventType = eventTypes.Single(e => e.Type == "Tabletop RPG Sessions"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("05/01/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("05/03/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Test", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Last Minute Deal Test 02", EventType = eventTypes.Single(e => e.Type == "Rave"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("05/02/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("05/04/2019 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                //events 11-15
                new Event { Title = "Last Minute Deal Test 03 ", EventType = eventTypes.Single(e => e.Type == "Dance"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("05/01/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("05/02/2019 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Last Minute Deal Test 04 ", EventType = eventTypes.Single(e => e.Type == "Concert"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("05/02/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("05/04/2019 9:30:00 PM"),
                            City = "Dallas", State = "Texas",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Last Minute Deal Test 05 ", EventType = eventTypes.Single(e => e.Type == "FurMeet"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("05/02/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("05/04/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Tea Time", EventType = eventTypes.Single(e => e.Type == "Tea Party"),
                            Description = "Drink some Tea",
                            StartDate = DateTime.Parse("11/18/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("11/18/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "TeaCompany", OrganizationContactInfo = "",
                            MaxTickets = 400, AvailableTickets = 270
                          },
                new Event { Title = "A Christmas Carol", EventType = eventTypes.Single(e => e.Type == "Theatrical Play"),
                            Description = "",
                            StartDate = DateTime.Parse("12/8/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/23/2019 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Playhouse Square", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 200
                          },
                //events 16-20
                new Event { Title = "The Nutcracker", EventType = eventTypes.Single(e => e.Type == "Ballet"),
                            Description = "",
                            StartDate = DateTime.Parse("12/09/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/14/2019 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Playhouse Square", OrganizationContactInfo = "",
                            MaxTickets = 700, AvailableTickets = 210
                          },
                new Event { Title = "Lilo and Stitch Party", EventType = eventTypes.Single(e => e.Type == "Children's Event"),
                            Description = "",
                            StartDate = DateTime.Parse("10/15/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("10/15/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Disney ", OrganizationContactInfo = "",
                            MaxTickets = 400, AvailableTickets = 110
                          },
                new Event { Title = "Wicked", EventType = eventTypes.Single(e => e.Type == "Musical"),
                            Description = "",
                            StartDate = DateTime.Parse("08/26/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("08/13/2020 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Broadway", OrganizationContactInfo = "",
                            MaxTickets = 610, AvailableTickets = 110
                          },
                new Event { Title = "The Godfather", EventType = eventTypes.Single(e => e.Type == "Movie Night"),
                            Description = "",
                            StartDate = DateTime.Parse("07/15/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("07/15/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Mafia", OrganizationContactInfo = "",
                            MaxTickets = 200, AvailableTickets = 100
                          },
                new Event { Title = "AvengerCon", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "",
                            StartDate = DateTime.Parse("06/11/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("06/13/2019 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Marvel", OrganizationContactInfo = "",
                            MaxTickets = 450, AvailableTickets = 200
                          },
                //events 21-25
                new Event { Title = "American Muscle", EventType = eventTypes.Single(e => e.Type == "Classic Car Show"),
                            Description = "",
                            StartDate = DateTime.Parse("05/20/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("05/24/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "MuscleCars", OrganizationContactInfo = "",
                            MaxTickets = 400, AvailableTickets = 250
                          },
                new Event { Title = "The Lion King", EventType = eventTypes.Single(e => e.Type == "Children's Event"),
                            Description = "",
                            StartDate = DateTime.Parse("03/08/2020 5:00:00 PM"),
                            EndDate = DateTime.Parse("03/10/2020 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Disney", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 350
                          },
                new Event { Title = "Game Of Thrones", EventType = eventTypes.Single(e => e.Type == "Movie Night"),
                            Description = "",
                            StartDate = DateTime.Parse("08/06/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("08/06/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "HBO", OrganizationContactInfo = "",
                            MaxTickets = 200, AvailableTickets = 100
                          },
                new Event { Title = "Carnival", EventType = eventTypes.Single(e => e.Type == "Gathering"),
                            Description = "",
                            StartDate = DateTime.Parse("01/26/2020 5:00:00 PM"),
                            EndDate = DateTime.Parse("01/26/2020 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "HPPT", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 200
                          },
                new Event { Title = "Kid Cudi", EventType = eventTypes.Single(e => e.Type == "Concert"),
                            Description = "",
                            StartDate = DateTime.Parse("09/29/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("09/29/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "RocketMortage FieldHouse", OrganizationContactInfo = "",
                            MaxTickets = 700, AvailableTickets = 200
                          },
                //events 26-30
                new Event { Title = "Phantom of the Oprea", EventType = eventTypes.Single(e => e.Type == "Musical"),
                            Description = "",
                            StartDate = DateTime.Parse("07/15/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/01/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Broadway", OrganizationContactInfo = "",
                            MaxTickets = 700, AvailableTickets = 250
                          },
                new Event { Title = "High School Musical", EventType = eventTypes.Single(e => e.Type == "Musical"),
                            Description = "",
                            StartDate = DateTime.Parse("04/03/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("04/20/2019 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Playhouse Square", OrganizationContactInfo = "",
                            MaxTickets = 800, AvailableTickets = 250
                          },
                new Event { Title = "Garage Sale", EventType = eventTypes.Single(e => e.Type == "Resale"),
                            Description = "",
                            StartDate = DateTime.Parse("07/25/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("07/25/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "The Neighbors", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 200
                          },
                new Event { Title = "The Boston Tea Party", EventType = eventTypes.Single(e => e.Type == "Tea Party"),
                            Description = "",
                            StartDate = DateTime.Parse("11/14/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("11/14/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "RedSoxFans", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 250
                          },
                new Event { Title = "Avengers behind the Scenes", EventType = eventTypes.Single(e => e.Type == "Movie Magic"),
                            Description = "",
                            StartDate = DateTime.Parse("06/26/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("06/29/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Marvel Artists", OrganizationContactInfo = "",
                            MaxTickets = 600, AvailableTickets = 250
                          },

            }.ForEach(e => context.Events.Add(e));

            base.Seed(context);
        }
    }
}