using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint4.Task6.V9.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint4.Task6.V9
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
            Console.WriteLine(" Задание #6                                                             ");
            Console.WriteLine(" Вариант #9                                                        ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                      ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Дан строковый массив данных  Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" ");
            Console.WriteLine("  используя класс Array подсчитайте количество элементов, длина которых меньше 7.    ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            var color = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= color.Length - 1; i++)
            {
                Console.WriteLine(color[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int count = ds.Calculate(color);

            Console.WriteLine("Количество элементов, длина которых меньше 7 = " + count);
            Console.ReadKey();
        }
    }
}