using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint4.Task0.V14.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint4.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #4                                                               ");
            Console.WriteLine(" Тема: Обработка структурных типов                                        ");
            Console.WriteLine(" Задание #0                                                              ");
            Console.WriteLine(" Вариант #14                                                             ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                              ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями         ");
            Console.WriteLine(" в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива.  {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}   ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

            Console.WriteLine("* Исходный массив: ");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            

           

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            Console.WriteLine("Cумма нечетных чисел" + ds.GetSumOddArrEl(numsArray));


            Console.ReadKey();
        }
    }
}
