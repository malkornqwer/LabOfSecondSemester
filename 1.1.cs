/********************************************
* Автор: Усиков С.А                         *
* Дата: 12.02.2023                          *
* Название: 2                               *
*********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n : ");
            string N = Console.ReadLine();
            char Second = N[1];
            Console.WriteLine("Число x = " + N.Remove(1, 1) + Second);
            Console.ReadKey();
        }
    }
}