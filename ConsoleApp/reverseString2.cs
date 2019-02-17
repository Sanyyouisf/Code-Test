using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ReverseString2
    {
        // reverse string without the revese function
        public string Reverse(string input)
        {
            string result = string.Empty;
            foreach (char c in input)
            {
                result = c + result; // concantenate the characters in a reverse mode
            }
            return result;
        }
    }
}
