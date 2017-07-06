using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop?
            //Why would you use a loop?
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue

            //FOR loops, WHILE loops, FOR EACH loops, DO-WHILE loops

            //FOR loops
            //Can be used for both counting and ITERATING through an array(or other collection type)
            //Looks like this:
            //for(initializer; condition; updater)
            //{ do something }

            //int i;
            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 50; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
