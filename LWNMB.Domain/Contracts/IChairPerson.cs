using System;
namespace LWNMB.Domain.Contracts
{
   public  interface IChairPerson
    {
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
    }
}
