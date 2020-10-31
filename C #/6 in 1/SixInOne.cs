using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_in_1
{
    class SixInOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Write1st(n: Convert.ToInt32(Console.ReadLine())); //вызов метода: параметр - ввод числа юзером

            Console.WriteLine("\n\nЗадание 2");
            ReverseNum(x: Console.ReadLine());

            Console.WriteLine("\n\nЗадание 3");
            Sum(y: Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\n\nЗадание 4");
            Console.WriteLine(Power(god: Convert.ToInt32(Console.ReadLine()),  rule: Convert.ToInt32(Console.ReadLine())));

            Console.WriteLine("\n\nЗадание 5"); // создание массива
            Max(arr: new[] { 2, -5, 16});
            Max(arr: new[] { -7, -80, 98});
            Max(arr: new[] { 53, -43, 16});

            Console.WriteLine("\nЗадание 6");
            Palindrom(Console.ReadLine());


            Console.ReadKey();
        }

        static void Write1st(int n)
        {
            Console.Write($"{n}"); //вывод переменной n 
            if (n > 1) Write1st(n: n - 1); //если n > 1, то этот метод вызывается и в нем из n вычитается 1
        }

        static void ReverseNum(string x, int i = 0)
        {
            var r = new string(x.Reverse().ToArray()); //-> переменная r уже содержит перевернутую строку из переменной x
            Console.Write(r[i]);
            if (i < r.Length - 1) ReverseNum(x, i: i + 1); // вызов метода до конца строки
        }

        static void Sum(int y, int res = 0)
        {
            if (y > 0) { Sum(y: y - 1, res: res += y); } //пока y > 0, прибавляем y к res
            else Console.WriteLine(res); // вывод переменной res
        }

        static int Power(int god, int rule) //где god - число, а rule - степень введен. числа
        {
            if (rule == 1) return god; //возвращает переменную god только для числа 1-ой степени
            return god * Power(god, rule: --rule); //иначе вызов метода
        }

        static void Max(int[] arr, int h = 0, int max = Int32.MaxValue)
        {
            if (h < arr.Length - 1) Max(arr, h: ++h, max: arr[h] > max ? arr[h] : max);
            //если текущ. элем-т массива > переменной max, то присваиваем max = arr[h]
            else Console.WriteLine(max);
        }

        static void Palindrom(string str, int g =0)
        {
            string s = new string(str.Reverse().ToArray()); //реверс строки переменной str
            if (g < str.Length) // если g < длины строки переменной str
            {
                if (str[g] == s[g]) Palindrom(str, g + 1); //если символ обычной и перевернутой строк равны, то вызываем метод
                else Console.WriteLine(false); //вывод false
            }
            else Console.WriteLine(true); //вывод true
        }
    }
}
