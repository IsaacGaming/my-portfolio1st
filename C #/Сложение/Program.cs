using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сложение
{
    class Program
    {
        static void Main(string[] args){
            int num, num_1;

            Console.WriteLine("Введите первое число:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + (num + num_1).ToString());
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
