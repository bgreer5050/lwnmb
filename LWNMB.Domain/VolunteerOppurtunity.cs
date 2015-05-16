using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.Domain
{
    public class VolunteerOppurtunity : LWNMB.Domain.Contracts.IVolunteerOppurtunity
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        public string Description { get; set; }
        public string DetailedDescription { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }


    }
}
