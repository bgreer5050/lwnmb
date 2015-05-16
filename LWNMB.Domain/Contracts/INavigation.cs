using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.Domain.Contracts
{
    public interface INavigation
    {
         int Id { get; set; } 
         ISection Section { get; set; }
         string LinkText { get; set; }
         string NavigateTo { get; set; }
    }

  
}
