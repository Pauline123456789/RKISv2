using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "XXIV";
            var roman = new Dictionary<char, int>()
            {
                { 'I',1 },
                { 'V',5 },
                { 'X',10 },
                { 'L',50 },
                { 'C',100 },
                { 'D',500 },
                { 'M',1000 },
            };

            int output = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (i == num.Length - 1)
                {
                    output += roman[num[i]];


                }
                else if (roman[num[i]] < roman[num[i + 1]])
                {
                    output += roman[num[i + 1]] - roman[num[i]];
                    i++;
                }
                else
                {
                    output += roman[num[i]];
                }
                
            }
            Console.WriteLine(output);
        }
    }
}
