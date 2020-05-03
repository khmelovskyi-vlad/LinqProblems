using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Toilet
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Write your name");
                var line = Console.ReadLine();
                if (line == "Max")
                {
                    Console.WriteLine("It is your toilet");
                    var key = Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Fuck you");
                    var key = Console.ReadKey(true);
                }
            }
        }
    }
}
