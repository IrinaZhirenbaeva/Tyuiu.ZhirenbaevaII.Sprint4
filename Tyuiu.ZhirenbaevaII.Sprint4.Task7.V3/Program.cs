using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint4.Task7.V3.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint4.Task7.V3
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
            Console.WriteLine(" Задание #7                                                             ");
            Console.WriteLine(" Вариант #3                                                        ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                      ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Дана строка из одноразрядных цифр 27182818");
            Console.WriteLine(" Преобразуйте ее в матрицу 4 на 2  и подсчитайте количество нечетных чисел в матрице.    ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            int n = 4; int m = 2;
            int[,] array = new int[n, m];
            string str = "27182818";
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t ");
                    index++;
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("количество нечетных чисел в матрице: " + res);

            Console.ReadKey();
        }
    }
}


