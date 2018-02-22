using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = System.IO.File.ReadAllText("../../ tekst.txt");
            Console.WriteLine(data);
        }
    }
}
