using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PrimeNumbers
    {

        public void PrimeList()
        {
            List<int> result = new List<int>();
           Console.WriteLine("enter the Max number of the Prime numbes");

            int maxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("the prime numbers between {0} and {1} are: ", 2, maxNumber);
            bool isPrime = true;
            //check the max
            for (int i = 2; i <= maxNumber; i++)
            {
                //check the factors
                for (int j = 2; j < maxNumber; j++)
                {
                    if (i != j &&  i  %j== 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
        }
    }
}
