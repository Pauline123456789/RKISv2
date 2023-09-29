using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2._2;
namespace ConsoleApp1
{
   


    public class Program
    {

        public static void Main(string[] args)
        {
            Train t_1 = new Train();
            t_1.point = "NOVOSIBIRSK";
            t_1.number = 1;
            t_1.time = "15:00";

            Train t_2 = new Train();
            t_2.point = "TOMSK";
            t_2.number = 2;
            t_2.time = "22:00";

            Train t_3 = new Train();
            t_3.point = "OMSK";
            t_3.number = 3;
            t_3.time = "21:00";


            while (true)
            {

                Console.WriteLine("Введите номер поезда от 1 до 3");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        t_1.writeInConsoleInfo(t_1.point, t_1.time, t_1.number);
                        break;
                    case "2":
                        t_2.writeInConsoleInfo(t_2.point, t_2.time, t_2.number);
                        break;
                    case "3":
                        t_3.writeInConsoleInfo(t_3.point, t_3.time, t_3.number);
                        break;
                }
            }
        }
    }
}
