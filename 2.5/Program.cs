using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _2._5;
namespace _2._5
{

    

    internal class Program
    {
        static void Main(string[] args)
        {
            program men_1 = new program("Paulina","Novoseltseva");
            program men_2 = new program();
            men_1.GetPrint();
            men_2.GetPrint();


        }
    }
}
