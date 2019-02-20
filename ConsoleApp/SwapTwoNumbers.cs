using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SwapTwoNumbers
    {
        public void Swap ()
        {
            int temp = 0;
            Console.WriteLine("enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("after swaping the first number is: {0} and the second number is: {1}",firstNumber,secondNumber);
        }
    }
}
