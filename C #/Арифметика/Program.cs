using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арифметика
{
    class Program
    {
        static void Main(string[] args){
            double num, num_1;
            Console.WriteLine("                                      Designed by YUNOV DEMID)\n");
            Console.WriteLine("Введите первое число:\n");
            Console.WriteLine("Примечание 1ое: Для вычисления длины окружности, введите число радиуса окружности в первое!");
            Console.WriteLine("Примечание 2ое: При введении десятичного числа, ставьте запятую(Например: 2,7), в противном случае, будет ошибка!");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:\n"); num_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n===============================================================================");
            Console.WriteLine("Результат при сложении: " + (num + num_1).ToString());
            Console.WriteLine("Результат при вычитании: " + (num - num_1).ToString());
            Console.WriteLine("Результат при умножении: " + (num * num_1).ToString());
            Console.WriteLine("Результат при делении: " + (num / num_1).ToString());
            Console.WriteLine("Результат при делении с остатком: " + (num % num_1).ToString());
            Console.WriteLine("\n===========================================================================");
            const float pi = 3.14f;
            Console.WriteLine("Вычисление длины окружности: " + (2*num*pi).ToString());
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
