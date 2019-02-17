using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ReverseString
    {
        //reverse string using reverse function
        public string reverse(string input)
        {
            char[] result = input.ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }
    }
}
