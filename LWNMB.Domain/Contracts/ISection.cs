using System;
namespace LWNMB.Domain.Contracts
{
   public interface ISection
    {
        ChairPerson Chairperson { get; set; }
        System.Collections.Generic.ICollection<ChairPerson> CoChairs { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}
