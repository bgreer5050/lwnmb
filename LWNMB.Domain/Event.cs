using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.Domain
{
    public class Event : LWNMB.Domain.Contracts.IEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TagLine { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Section> Sections { get; set; }

        public virtual ICollection<EventDate> EventDates { get; set; }
        public virtual ICollection<VolunteerOppurtunity> VolunteerOppurtunities { get; set; }

    }

    public class EventDate : LWNMB.Domain.Contracts.IEventDate 
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }


    public class FundRaiser : Event
    {

    }
}
