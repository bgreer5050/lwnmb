using System;
namespace LWNMB.Domain.Contracts
{
    public interface IBoardPosition
    {
        BoardMembers BoardMember { get; set; }
        DateTime EndDate { get; set; }
        int Id { get; set; }
        DateTime StartDate { get; set; }
    }
}
