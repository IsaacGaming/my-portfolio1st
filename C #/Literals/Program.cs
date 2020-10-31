using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            // булевые литералы
            Console.WriteLine(true);
            Console.WriteLine(false);

            // строковые литералы
            Console.WriteLine("Не лезь, блять, дебил, сука ебанный");
            Console.WriteLine("I'm \"not\" mimic "); // \" *_* \"
            Console.WriteLine("I'm \nmimic "); // перенос строки с помощью управляющих последовательностей

            // симв. литералы
            Console.WriteLine('\x78');      // ASCII (это x)
            Console.WriteLine('ф');

            // целочисл. литералы
            Console.WriteLine(0xFF);        // 255
            Console.WriteLine(0b1011);      // 11
            Console.WriteLine(-11);

            // веществ. литералы
            Console.WriteLine(3.2e3);   // 3200
            Console.WriteLine(1.2E-1);  // 0.12

            Console.ReadKey();
        }
    }
}
