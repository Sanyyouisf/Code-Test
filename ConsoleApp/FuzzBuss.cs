using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public  class FuzzBuss
    {
        public void fuzzBuzz (int max)
        {
            for (var i = 0; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fuss buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
   }
}
