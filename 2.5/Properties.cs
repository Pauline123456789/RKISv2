using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class program
    {
        private string name;
        private string surname;

        public program() { name = "Неизвестно"; surname = "Неизвестно"; }
        public program(string name, string surname) { this.name = name; this.surname = surname; }

        public void GetPrint()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surname}");
        }

        ~program()
        {
            Console.WriteLine($"{name} has deleted");
        }

    }
}
