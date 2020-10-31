using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
         int day, month, year; double a; 
         Console.WriteLine("Пример ввода даты: 1.9.2002 \nВведите число дня:");
         day = int.Parse(Console.ReadLine());

         Console.WriteLine("Введите число месяца:");
         month = int.Parse(Console.ReadLine());

         Console.WriteLine("Введите число года:");
         year = int.Parse(Console.ReadLine()); 

         if (year < 20) // Предупреждение
         { Console.WriteLine("\nОшибка! Число года меньше 19, закройте прогу и вводите все сначала"); }

           
         do { a = year / 4; } while (a <= 4); //Проверка на високосный год 

         if (day == 31 & ( month == 1 | month == 3 | month == 5 | month == 7 | month == 8 | month == 10))
         { month += 1; day -= 31; }   // Переход на следующий месяц

         if (day > 30 & month == 12)  // Переход на следующий год 
         {
           year = year + 1;
           month -= 11;
           day -= 31;
         }

         if (month == 2 & day > 27 & a < 4) // Переход на следующий месяц из февраля
         { month += 1; day -= 28; }


         if (month == 2 & day == 29 & a == 4)  // Переход на следующий месяц из февраля 
         { month += 1; day -= 29; }            // в случае високосного года


         if (day == 30 & (month == 4 | month == 6 | month == 9 | month == 11))    // Переход на следующий месяц из 
         { month += 1; day -= 30; }                                               // месяцев с 30-ю днями

         day += 1;

         Console.WriteLine("Следующая дата: " + day + "." + month + "." + year + "\nПросто нажмите любую кнопку)");
         Console.ReadKey();
        }
    }
}
