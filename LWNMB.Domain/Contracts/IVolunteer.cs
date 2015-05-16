using System;
namespace LWNMB.Domain.Contracts
{
   public interface IVolunteer
    {
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
    }
}
