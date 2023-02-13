/********************
* Автор: Усиков С.А *
* Дата: 12.02.2023  *
* Название: 1.2     *
*********************/
using System;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a real number (a):");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer (n):");
            int n = int.Parse(Console.ReadLine());

            double Soul = 1;// Soul - результат возведения в степень n числа а

            for (int i = 0; i < n; i++)// Цикл умножения Soul на a n раз
            {
                Soul *= a;
            }

            Console.WriteLine("a^n = " + Soul);
            Console.ReadKey();
        }
    }
}


