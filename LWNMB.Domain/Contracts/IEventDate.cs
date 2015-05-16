using System;
namespace LWNMB.Domain.Contracts
{
   public interface IEventDate
    {
        DateTime End { get; set; }
        int Id { get; set; }
        DateTime Start { get; set; }
    }
}
