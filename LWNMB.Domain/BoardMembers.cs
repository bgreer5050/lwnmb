using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWNMB.Domain.Contracts;

namespace LWNMB.Domain
{
    public class BoardMembers : IBoardMembers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    
    }

    public class BoardPosition : IBoardPosition
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual BoardMembers BoardMember { get; set; }
    }
}
