using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Train
    {
        public string pynkt, time;
        public int nomer;

        public void writeInConsoleInfo(string pynkt, string time, int nomer)
        {
            Console.WriteLine("Номер поезда: {0}\nВремя: {1}\nПункт: {2}", nomer, time, pynkt);
        }
    }
}
