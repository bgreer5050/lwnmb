using System;
namespace LWNMB.Domain.Contracts
{
    public interface IEvent
    {
        string Description { get; set; }
        System.Collections.Generic.ICollection<EventDate> EventDates { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        System.Collections.Generic.ICollection<Section> Sections { get; set; }
        string TagLine { get; set; }
        System.Collections.Generic.ICollection<VolunteerOppurtunity> VolunteerOppurtunities { get; set; }
    }
}
