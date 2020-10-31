using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTool
{
    class Program
    {
        static void Main(string[] args)
        {
            int on;
            do {
                Console.Clear();
                Console.WriteLine("Введите начальное целое число");
                int i7 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите конечное целое число");
                int i5 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число шагов");
                int i = int.Parse(Console.ReadLine());

                Random i9 = new Random();
                Console.WriteLine("\n");
                for (int x = 0; x < i; x++) { Console.WriteLine("{0, -11} ||{1, -11}||{2, -11}||{3, -11}||", x, GenerateDigit(i9, i7, i5), GenerateDigit(i9, i7, i5), GenerateDigit(i9, i7, i5));}

                Console.WriteLine("\nПродолжить работу? Да - 1, Нет - 0");
                on = Int32.Parse(Console.ReadLine());
            } while (on == 1);
        }

        static int GenerateDigit(Random i9, int i7, int i5)
        {
            return i9.Next(i7, i5);
        }
    }
}
