using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.Domain
{
    public class WebsitePost : LWNMB.Domain.Contracts.IWebsitePost 
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime PublishEndDate { get; set; }
        public string FrontPage { get; set; }
        public Section Section { get; set; }

    }
}
