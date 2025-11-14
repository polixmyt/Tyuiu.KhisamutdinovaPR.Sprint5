using System;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task1.V10.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Таск 1 | Вариант 10";

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Спринт 5 | Таск 1 | Вариант 10");
            Console.WriteLine("F(x) = (2*cos(x) + 2) / (2*x - 1) + cos(x) - 5*x + 3");
            Console.WriteLine($"Диапазон табулирования: [{startValue}; {stopValue}], шаг 1");
            Console.WriteLine("Результат записан в файл:");
            Console.WriteLine(path);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Таблица значений:");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                int x = startValue;

                Console.WriteLine("   x\tF(x)");
                Console.WriteLine("------------------------");

                foreach (string line in lines)
                {
                    Console.WriteLine($"{x,4}\t{line}");
                    x++;
                }
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}