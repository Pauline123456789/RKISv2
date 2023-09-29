using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Train
    {
        public string point, time;
        public int nomber;

        public void writeInConsoleInfo(string point, string time, int nomber)
        {
            Console.WriteLine("Номер поезда: {0}\nВремя: {1}\nПункт: {2}", nomber, time, point);
        }
    }
}
