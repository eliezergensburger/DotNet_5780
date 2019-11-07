using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Targil1_2.Entities;

namespace Targil1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Host host = new Host();
            host.AddYomBadid(new int[] { 0, 3 });
            if (host.CheckYomPanuy(new int[] { 0, 3 }))
            {
                Console.WriteLine("panuy");
            }
            else
            {
                Console.WriteLine("Too bad!!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
