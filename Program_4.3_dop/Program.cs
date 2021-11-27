using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4._3_dop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: В: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: С: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int S1 = 0; // количество квадратов по одной стороне
            int S2 = 0; // количество квадратов по другой стороне
            int Sum = 0; // суммарное количество квадратов

            while (A >= C)
            {
                A -= C;
                S1++;
            } // цикл определяющий S1
            while (B >= C)
            {
                B -= C;
                S2++;
            } // цикл определяющий S2

            for (int i = 0; i < S1; i++) // цикл определяющий Sum
            {
                Sum += S2;
            }
            Console.WriteLine("Количество квадратов равно {0} ", Sum);

            Console.WriteLine("Для завершения нажмите на любого клавиша");
            Console.ReadKey();
        }
    }
}
