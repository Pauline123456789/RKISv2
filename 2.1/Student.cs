using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_
{
    class Student
    {
        public string familia, data;
        public int number
;
        public int[] progress;

        public void writeInConsoleInfo(string surname, string data, int number
, int[] progress)
        {
            Console.WriteLine("Фамилия: {0}\nДень рождение: {1}\nГруппа: {2}\n", surname, data, number);
            Console.WriteLine("Успеваемость:");
            foreach (int i in progress)
            {
                Console.Write(i + " ");
            }
        }


    }
}
