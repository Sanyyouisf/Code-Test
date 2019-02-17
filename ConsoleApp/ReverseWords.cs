using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //reverse words "How Are You" => "you Are How"
    // without using the reverse function
    public class ReverseWords
    {
        public string ReverseStringWords(string input)
        {
            string result = string.Empty;
            string result2 = string.Empty;

            foreach (char c in input)
            {
                if (c.Equals(' '))
                {
                    result = result2 + result;
                    result = c + result;
                    result2 = string.Empty;
                }
                else
                {
                    result2 += c;
                }
            }
            result = result2 + result;
            return result;
        } 
    }
}
