// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30
// Description: Вызов библиотеки, запись в бинарный файл и вывод результата на консоль.

using System;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Таск 3 | Вариант 30";

            DataService ds = new DataService();
            int x = 3;

            // Сохранение результата в бинарный файл
            string path = ds.SaveToFileTextData(x);

            // Чтение результата из файла
            double value;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                value = br.ReadDouble();
            }

            Console.WriteLine("Спринт 5 | Таск 3 | Вариант 30");
            Console.WriteLine("Выражение: y = (x^3 - 1) / (4 * x^2)");
            Console.WriteLine($"x = {x}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Бинарный файл: {path}");
            Console.WriteLine($"Значение y (из файла): {value:F3}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}