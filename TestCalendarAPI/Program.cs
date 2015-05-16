using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Calendar.v3;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Services;

namespace TestCalendarAPI
{
    class Program
    {
        private static Object thisLock;

        static void Main(string[] args)
        {
            thisLock = new Object();

            lock(thisLock)
            {
                Console.WriteLine("test");
            }
        }
    }
}
