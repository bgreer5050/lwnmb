using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.Domain
{
    public class BoardMembers : LWNMB.Domain.Contracts.IBoardMembers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    
    }

    public class BoardPosition : LWNMB.Domain.Contracts.IBoardPosition
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual BoardMembers BoardMember { get; set; }
    }
}
