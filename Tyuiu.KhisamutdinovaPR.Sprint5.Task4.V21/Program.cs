// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21
// Description: Чтение X из файла и вывод результата вычисления на консоль.

using System;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Таск 4 | Вариант 21";

            // По условию: файл создаётся вручную по этому пути
            string folder = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask4V0.txt";
            string path = Path.Combine(folder, fileName);

            DataService ds = new DataService();

            try
            {
                double result = ds.LoadFromDataFile(path);

                Console.WriteLine("Спринт 5 | Таск 4 | Вариант 21");
                Console.WriteLine("Файл с входными данными: " + path);
                Console.WriteLine("Формула: y = x^3 * cos(x) + 2x");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Результат вычисления y = {result:F3}");
                Console.WriteLine("---------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}