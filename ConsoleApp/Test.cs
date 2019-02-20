using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public  class Test
    {
        public string Reverse (string input)
        {
            string result = string.Empty;
            //string output = string.Empty;
            //foreach (var c in input)
            //{
            //    if (c.Equals(' '))
            //    {
            //        result = output + result;
            //        result = c + result;
            //        output = string.Empty;
            //    }
            //    else
            //    {
            //        output += c; 
            //    }
            //}
            //result = output + result;

            //return result;

            //foreach (var c in input)
            //{
            //    result = c + result;

            //}

            string[] array = input.Split(' ');
            Array.Reverse(array);
            result = string.Join(" ", array); 
            return result;

        }
    }
}
