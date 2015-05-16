using System;
namespace LWNMB.Domain.Contracts
{
   public interface IVolunteerOppurtunity
    {
        string Description { get; set; }
        string DetailedDescription { get; set; }
        DateTime EndDateTime { get; set; }
        Event Event { get; set; }
        int EventId { get; set; }
        int Id { get; set; }
        DateTime StartDateTime { get; set; }
    }
}
