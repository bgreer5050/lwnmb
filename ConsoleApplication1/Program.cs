using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Ticks);
            long ticks = DateTime.Now.Ticks;

            DateTime dt = new DateTime(ticks);

            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.Ticks);
            
        }
    }
}
