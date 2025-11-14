using System;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task2.V13.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Таск 2 | Вариант 13";

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы матрицы 3x3 (целые числа):");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine();
            Console.WriteLine("Матрица после замены нечётных элементов на 0:");
            PrintMatrix(matrix);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Результат сохранён в файл:");
            Console.WriteLine(path);
            Console.WriteLine("--------------------------------------------");

            if (File.Exists(path))
            {
                Console.WriteLine("Содержимое OutPutFileTask2.csv:");
                Console.WriteLine(File.ReadAllText(path));
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}