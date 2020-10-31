using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool_v1._0
{
    class Program
    {
        static void Alert()
        {
            Console.WriteLine("Примечание: При введении десятичного числа, ставьте запятую(Например: 2,7), " +
                "в противном случае, будет ошибка!\nВведите первое число:");
        }
        
        static void Equations(string [] args) 
        { 
        
        }
        static void Main(string [] args)
        {
            int n1;
            Console.WriteLine("                                      Designed by YUNOV DEMID)"); 
            Console.WriteLine("                                      CreatedDate: 09.05.2019\n");

            do { 
            Console.WriteLine("==============================================================================================================\n");
            Console.WriteLine("Выберите нужный вам пункт:" +
                "\nАрифметические операции: 1 - сложение; 2 - вычитание; 3 - умножение; 4 - деление; 5 - деление с остатком;" +
                "\n6 - возведение числа в квадрат; 7 - возведение числа в куб; 8 - решение квадратных уравнений;" +
                "\n9 - извлечение квадратного корня; 10 - извлечение кубического корня");
            Console.WriteLine("\nГеометрические операции: 11 - нахождение длины окружности; 12 - нахождение площади параллелограмма;" +
                "\n13 - нахождение площади треугольника; 14 - вычисление длины гипотенузы прямоугольного треугольника(т. Пифагора)" +
                "\n15 - площадь круга; 16 - синус в прямоугольном треугольнике; 17 - косинус в прямоугольном треугольнике\n");
            Console.WriteLine("\n============================================================================================================");

                int n; double num, num_1, x1, x2, a, b, c, d; const float pi = 3.14f;

             n = int.Parse(Console.ReadLine());
             num = double.Parse(Console.ReadLine());
             num_1 = double.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Alert();                      
                        Console.WriteLine("Введите второе число:\n");      
                        Console.WriteLine("Результат при сложении: " + (num + num_1).ToString());
                        break;

                    case 2:
                        Alert();
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число:\n");
                        num_1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат при вычитании: " + (num - num_1).ToString());
                        break;

                    case 3:
                        Alert();
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число:\n");
                        num_1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат при умножении: " + (num * num_1).ToString());
                        break;

                    case 4:
                        Alert();
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число:\n");
                        num_1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат при делении: " + (num / num_1).ToString());
                        break;

                    case 5:
                        Alert();
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число:\n");
                        num_1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат при делении с остатком: " + (num % num_1).ToString());
                        break;

                    case 6:
                        Alert();
                        num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат при возведении в квадрат: " + num * num);
                        break;

                    case 7:
                        Alert();
                        num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат при возведении в куб: " + Math.Pow(num, 3));
                        break;

                    case 8:
                        Console.WriteLine("Примечание: При введении в переменные десятичных чисел, нужно ставить запятую(Например:2,7).");
                        Console.WriteLine("Введите переменную a"); a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите переменную b"); b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите переменную c"); c = double.Parse(Console.ReadLine());

                        Console.WriteLine(a + "x^2 +" + b + "x +" + c + "=0");
                        d = Convert.ToDouble((b * b) - (4 * a * c)); Console.WriteLine("Дискриминант: " + d);

                        if (d > 0)
                        {
                            x1 = Convert.ToDouble(((-b) + Math.Sqrt(d)) / (2 * a));
                            x2 = Convert.ToDouble(((-b) - Math.Sqrt(d)) / (2 * a));
                            Console.WriteLine("Это квадратное уравнение имеет 2 корня: x1= " 
                                + x1 + ";" + " x2= " + x2.ToString());
                        }

                        if (d < 0)
                            Console.WriteLine("Это квадратное уравнение не имеет корней, поэтому у него нет решений!");

                        else
                        {
                            x1 = Convert.ToDouble((-b) / (2 * a));
                            Console.WriteLine("Это квадратное уравнение имеет 1 корень: x1=" + x1.ToString());
                        }
                        break;

                    case 9:
                        Alert();
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат при извлечении квадратного корня: " + Math.Sqrt(num));
                        break;

                    case 10:
                        Alert();
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат при извлечении кубического корня: " + Math.Pow(num, 1 / 3f));
                        break;

                    case 11:
                        Alert();
                        num = double.Parse(Console.ReadLine()); Console.WriteLine("Вычисление длины окружности: " 
                            + (2 * num * pi).ToString());
                        break;

                    case 12:
                        Alert();
                        a = double.Parse(Console.ReadLine()); Console.WriteLine("Введите число длины высоты параллелограмма:");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат площади параллелограмма: " + a * b);
                        break;

                    case 13:
                        Alert();
                        a = double.Parse(Console.ReadLine()); Console.WriteLine("Введите число длины высоты треугольника:");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат площади треугольника: " + (a * b/2));
                        break;

                    case 14:
                        Alert();
                        a = double.Parse(Console.ReadLine()); Console.WriteLine("Введите число длины 2го катета: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Длина гипотенузы: "+ Math.Sqrt((a*a)+(b*b))); 
                        break;

                    case 15:
                        Alert();
                        d = double.Parse(Console.ReadLine()); Console.WriteLine("Результат площади круга: " 
                            + (pi*d*d).ToString());
                        break;

                    case 16:
                        Alert();
                        a = double.Parse(Console.ReadLine()); Console.WriteLine("Введите число длины гипотенузы: ");
                        b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("sin(a)="+ a / b);
                        break;

                    case 17:
                        Alert();
                        a = double.Parse(Console.ReadLine()); Console.WriteLine("Введите число длины гипотенузы: ");
                        b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("cos(a)=" + a / b);
                        break;
                }
                
                Console.WriteLine("Выйти из программы? да - 1; нет - 0"); n1 = int.Parse(Console.ReadLine());
            }   while (n1 == 0);
        }
    }
}
