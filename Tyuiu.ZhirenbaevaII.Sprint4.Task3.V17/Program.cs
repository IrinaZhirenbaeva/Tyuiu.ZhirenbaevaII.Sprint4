using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint4.Task3.V17.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint4.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #4                                                               ");
            Console.WriteLine(" Тема: Обработка структурных типов                                        ");
            Console.WriteLine(" Задание #3                                                             ");
            Console.WriteLine(" Вариант #17                                                         ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                      ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 1 до 8.  ");
            Console.WriteLine(" Найдите сумму элементов в четвертом столбце массива.    ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            int[,] mtrx = new int[5, 5] { { 6, 4, 2, 2, 1 },
                              { 3, 6, 5, 4, 1 },
                              { 5, 2, 3, 1, 6 },
                              { 8, 8, 4, 5, 3 },
                              { 7, 4, 5, 1, 6 }, };
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

          

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            Console.WriteLine("Сумма четвертого столбца = " + ds.Calculate(mtrx));

            Console.ReadKey();
        }
    }
}

