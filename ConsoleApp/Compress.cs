using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Compress
    {
        //Given a string "aaabbbcc", compress it, = "a3b3c2" 

        public string CompressString(string input)
        {
            string result = "";
            int count = 0;
            string x = input[0].ToString();
            for (int i = 0; i<= input.Length-1; ++i)
            {  
                if (x.Equals(input[i].ToString()))
                {
                    x = input[i].ToString();
                    count++;
                }
                else
                {
                    result += x + count;
                    x = input[i].ToString();
                    count = 1;
                }                
            }
            result += x + count;
            return result;
        }
    }
}
