using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task2.V13.Lib
{
    public class DataService : ISprint5Task2V13
    {
        /// <summary>
        /// Заменяет нечётные элементы матрицы на 0,
        /// сохраняет результат в CSV-файл OutPutFileTask2.csv
        /// во временной папке и возвращает путь к файлу.
        /// </summary>
        public string SaveToFileTextData(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Строим строки CSV
            string[] lines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                int[] rowValues = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    // заменяем нечётные элементы на 0 прямо в исходной матрице
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }

                    rowValues[j] = matrix[i, j];
                }

                // строка вида: 0;6;0
                lines[i] = string.Join(";", rowValues);
            }

            // Путь: temp-папка + OutPutFileTask2.csv
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string fullPath = Path.Combine(tempDir, fileName);

            // Записываем без лишнего перевода строки в конце
            string text = string.Join(Environment.NewLine, lines);
            File.WriteAllText(fullPath, text);

            return fullPath;
        }
    }
}