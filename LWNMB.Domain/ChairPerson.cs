using LWNMB.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.Domain
{
    public class ChairPerson : IChairPerson
    {
      
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

       
    }
}
