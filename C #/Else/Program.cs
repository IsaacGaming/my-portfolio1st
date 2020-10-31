using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else
{
    class Program
    {
    static void Main(string[] args)
        {
           double x1, x2, a, b, c, d; int e;
                Console.WriteLine("                                              Designed by YUNOV DEMID)");
                Console.WriteLine("                                             CreatedDate: 28.04.2019\n");
            do { 
                Console.WriteLine("ax^2+bx+c=0\nПродолжить работу? yes - 1/ no - 0");
                e =Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Примечание: При введении в переменные десятичных чисел, нужно ставить запятую(Например:2,7).");
                Console.WriteLine("Введите переменную a"); a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите переменную b"); b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите переменную c"); c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(a+"x^2 +"+b+"x +"+c+"=0".ToString());
                d = Convert.ToDouble((b * b) - 4 * a * c); Console.WriteLine("Дискриминант: " + d);
                if (d > 0)
                {
                    x1 = Convert.ToDouble(((-b) + Math.Sqrt(d)) / (2 * a));
                    x2 = Convert.ToDouble(((-b) - Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine("Это квадратное уравнение имеет 2 корня: x1=" + x1 + ";" + " x2=" + x2.ToString());
                }

                else if (d < 0)
                    Console.WriteLine("Это квадратное уравнение не имеет корней, поэтому у него нет решений!");

                else
                {
                    x1 = Convert.ToDouble((-b) / (2 * a));
                    Console.WriteLine("Это квадратное уравнение имеет 1 корень: x1=" + x1.ToString());
                }
            } while (e==1);
            Console.WriteLine("Нажмите любую клавишу для закрытия проги)");
            Console.ReadLine();
        }
    }
}
