using System;
namespace LWNMB.Domain.Contracts
{
   public interface IBoardMembers
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }
}
