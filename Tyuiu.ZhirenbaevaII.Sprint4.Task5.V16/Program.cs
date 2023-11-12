using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint4.Task5.V16.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint4.Task5.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();
                Random rnd = new Random();

                Console.Title = "Спринт #4 | Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1";

                Console.WriteLine("**");
                Console.WriteLine(" Спринт #4                                                               ");
                Console.WriteLine(" Тема: Обработка структурных типов                                        ");
                Console.WriteLine(" Задание #5                                                             ");
                Console.WriteLine(" Вариант #16                                                        ");
                Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                      ");
                Console.WriteLine("**");
                Console.WriteLine("* УСЛОВИЕ:                                                                ");
                Console.WriteLine(" Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -6 до 3.  ");
                Console.WriteLine("  Заменить положительные элементы на 1.    ");
                Console.WriteLine("**");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
                Console.WriteLine("**");

                Console.Write("Введите количество строк в массиве: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество столбцов в массиве: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[rows, columns];
                Console.WriteLine("***************************************************************************");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = rnd.Next(-6, 4);
                    }
                }
                Console.WriteLine("\nМассив: ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                int[,] res = ds.Calculate(matrix);

                Console.WriteLine("Массив, где положительные элементы заменены на 1: ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{res[i, j]} \t");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}