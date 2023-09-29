using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using Student_;

namespace ConsoleApp1
{
    

    public class Program
    {

        public static void Main(string[] args)
        {
            Student poulina = new Student();
            poulina.surname = "Novoseltseva";
            poulina.data = "12.10.2003";
            poulina.number = 621;
            poulina.progress = new[] { 4, 3, 5, 4, 3 };

            
            bool rabota = true;
            while (rabota)
            {
                Console.WriteLine("Введите 1 для вывода, 2 для изменения данных");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        poulina.writeInConsoleInfo(poulina.surname, poulina.data, poulina.number,
                            poulina.progress);
                        
                        break;
                    case "2":
                        Console.WriteLine("Введите 1 для изменения фамилии, 2 дня рождения, 3 группы, 0 для вывода");
                        string b = Console.ReadLine();
                        {
                            switch (b)
                            {
                                case "1":
                                    Console.WriteLine("Введите новую фамилию");
                                    string newsurname = Console.ReadLine();
                                    poulina.surname = newsurname;
                                    break;
                                case "2":
                                    Console.WriteLine("Введите новую дату дня рождения");
                                    string newdr = Console.ReadLine();
                                    poulina.data = newdr;
                                    break;
                                case "3":
                                    Console.WriteLine("Введите новую группу");
                                    int newnumber = Convert.ToInt32(Console.ReadLine());
                                    poulina.number = newnumber;
                                    break;
                                case "0":
                                    poulina.writeInConsoleInfo(poulina.surname, poulina.data, poulina.number,
                                        poulina.progress);
                                    
                                    break;
                            }
                        }
                        break;

                }
            }

        }
    }
}
