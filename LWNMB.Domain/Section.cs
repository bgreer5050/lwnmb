using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.Domain
{
    public class Section : LWNMB.Domain.Contracts.ISection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ChairPerson Chairperson { get; set; }
        public virtual ICollection<ChairPerson> CoChairs { get; set; }
    }

    public class ChairPerson : LWNMB.Domain.Contracts.IChairPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
