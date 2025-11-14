// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26
// Description: Вызов библиотеки, вывод пути к файлу и его содержимого.

using System;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Таск 0 | Вариант 26";

            DataService ds = new DataService();

            int x = 2;

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("Спринт 5 | Таск 0 | Вариант 26");
            Console.WriteLine("Выражение: F(x) = 0.7x^3 + 1.52x^2");
            Console.WriteLine($"x = {x}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Результат записан в файл:");
            Console.WriteLine(path);
            Console.WriteLine("----------------------------------------");

            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Файл не найден!");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}