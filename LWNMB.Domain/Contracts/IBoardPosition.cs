using System;
namespace LWNMB.Domain.Contracts
{
    public interface IBoardPosition
    {
       
        DateTime EndDate { get; set; }
        int Id { get; set; }
        DateTime StartDate { get; set; }
    }
}
