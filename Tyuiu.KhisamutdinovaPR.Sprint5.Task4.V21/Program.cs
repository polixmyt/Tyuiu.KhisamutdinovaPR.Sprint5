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

            string folder = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask4V21.txt";
            string path = Path.Combine(folder, fileName);

            DataService ds = new DataService();

            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("Спринт 5 | Таск 4 | Вариант 21");
            Console.WriteLine($"Формула: y = x^3 * cos(x) + 2x");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"X из файла = {File.ReadAllText(path)}");
            Console.WriteLine($"Результат = {result:F3}");
            Console.WriteLine("----------------------------------------");

            Console.ReadKey();
        }
    }
}