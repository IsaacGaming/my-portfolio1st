using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, d;
            try
            {
                Console.WriteLine("Введите переменную a"); a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите переменную b"); b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите переменную c"); c = double.Parse(Console.ReadLine());

                Console.WriteLine($"{a} x^2 + {b}x + {c} = 0");

                if (a != 0 && b != 0)
                {
                    d = Convert.ToDouble((b * b) - (4 * a * c)); Console.WriteLine($"Дискриминант: {d}");
                    if (d > 0)
                    {
                        x1 = Convert.ToDouble(((-b) + Math.Sqrt(d)) / (2 * a));
                        x2 = Convert.ToDouble(((-b) - Math.Sqrt(d)) / (2 * a));
                        Console.WriteLine($"Это квадратное уравнение имеет 2 корня: x1 = {x1}; x2 = {x2}");
                    }

                    if (d < 0) Console.WriteLine("Это квадратное уравнение не имеет корней, поэтому у него нет решений!");

                    else
                    {
                        x1 = Convert.ToDouble((-b) / (2 * a));
                        Console.WriteLine($"Это квадратное уравнение имеет 1 корень: x1 = {x1}");
                    }
                }
                else { Console.WriteLine("Ошибка! Неверная запись уравнения!"); }
                Profession();
                Console.ReadKey();

            }
            catch { Console.WriteLine("Ошибка: пустые значения!"); }

        }
        public static void Profession()
        {
            Console.WriteLine("Введите темперамент (холерик, сангвиник, флегматик, меланхолик): ");
            string temp = Console.ReadLine();
            Console.WriteLine("Введите время года рождения (зима, весна, лето, осень): ");
            string season = Console.ReadLine();
            
            if ((temp == "сангвиник" || temp == "флегматик") && (season == "зима" || season == "весна" || season == "лето"))
                 Console.WriteLine("Вам подойдут профессии технического и естественно-научного профиля!");
            
            if ((temp == "сангвиник") && (season == "зима" || season == "осень"))
                 Console.WriteLine("Вам точно подойдет медицинское направление!");
            
            else Console.WriteLine("Вам подойдут профессии из области гуманитарных наук!"); 

            Console.WriteLine("Какие вам нравятся профили? (Это для выбора нужной вам профессии)" +
                "\nтехнический/естественно-научный/медицинский?");
            string choice = Console.ReadLine();
            if (choice == "технический")
                Console.WriteLine("Программист");
            if (choice == "естественно-научный")
                Console.WriteLine("Ядерная физика");
            if (choice == "медицинский") 
            {
                Console.WriteLine("Нравится ли Вам общаться с людьми? Да/Нет?");
                choice = Console.ReadLine();
                    if (choice == "да")
                        Console.WriteLine("Терапевт");
                    if (choice == "нет")
                        Console.WriteLine("Хирургия и патологическая анатомия");
            }
        }
    }
}
