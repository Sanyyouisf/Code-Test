using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ReverseWords2
    {
        // revers the input words by converting to array of string 
        // reverse the Array and then convert it back to string 
        public string Reverse(string input )
        {
            string[] array = input.Split(' ');
            Array.Reverse(array);
            string result = string.Join(" ", array);
            return result;

            //or simply in one line 
            //string result = string.Join(" ", input.Split(' ').Reverse());
            //return result;
        }
    }
}
