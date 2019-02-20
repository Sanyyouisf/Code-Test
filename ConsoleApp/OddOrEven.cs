using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class OddOrEven
    {
        public void OddEven (int n)
        {
            if (n %2 == 0)
            {
                Console.WriteLine("{0} is even number", n);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} is odd number", n);
                Console.ReadLine();
            }
        }
    }
}
