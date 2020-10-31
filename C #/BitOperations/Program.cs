using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperations
{
    class Program
    {
        static void Main(string[] args)
        {   
            // логическое умножение
            int x = 2, y = 5; // 010 and 101
            Console.WriteLine(x & y); // = 0
            
            // логическое сложение
            x = 2; y = 5; // 010 and 101
            Console.WriteLine(x | y); // = 7 (111)

            // исключающее ИЛИ 
            /*Если у нас значения текущего разряда у обоих чисел разные, то возвращается 1, иначе возвращается 0.
              Таким образом, мы получаем из 9^5 в качестве результата число 12.
              Чтобы расшифровать число, мы применяем ту же операцию к результату. */

            x = 45; //101101
            int key = 102, encrypt = x ^ key, decrypt = encrypt ^ key; //ключ в двоичной форме 1100110           

            Console.WriteLine("Зашифрованное число: " + encrypt);
            Console.WriteLine("Расшифрованное число: " + decrypt);

            // инверсия
            y = 12;                 // 00001100
            Console.WriteLine(~y);      // 11110011 (-13)

            // инверсия для отрицательных чисел
            y =~12; y += 1;       
            Console.WriteLine(y);      // 12

            // операции сдвига
            x = y = 4; // х - это число, у - кол-во разрядов. << или >> - направление смещения разрядов числа
            Console.WriteLine(x << y);
            Console.WriteLine(x >> y);

            Console.ReadKey();
        }
    }
}
