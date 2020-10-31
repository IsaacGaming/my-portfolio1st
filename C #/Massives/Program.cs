using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massives
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Нажмите 0...2, потом ENTER ");
                int[] demid = new[] { 1, 3, 5 };

                foreach (int i in demid)
                {
                    Console.WriteLine(i);
                }

            }

            catch
            { Console.WriteLine("ОШИБКА!!! Индекс массива начинается с 0"); }



            Console.ReadKey();
        }
    }
}
