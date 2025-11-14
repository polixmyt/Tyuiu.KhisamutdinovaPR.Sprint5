// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26
// Description: Вычисление F(x) и сохранение результата в текстовый файл.

using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        /// <summary>
        /// Вычисляет значение функции F(x) = 0.7x^3 + 1.52x^2,
        /// округляет до трех знаков, сохраняет в файл OutPutFileTask0.txt
        /// во временной папке и возвращает полный путь к файлу.
        /// </summary>
        /// <param name="x">Аргумент функции.</param>
        /// <returns>Полный путь к созданному файлу.</returns>
        public string SaveToFileTextData(int x)
        {
            // 1. Вычисляем значение функции
            double value = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            value = Math.Round(value, 3);

            // 2. Формируем путь: temp-папка + имя файла
            string tempDir = Path.GetTempPath();          // системная временная директория
            string fileName = "OutPutFileTask0.txt";      // имя по условию
            string fullPath = Path.Combine(tempDir, fileName);

            // 3. Записываем значение в файл (как текст, с 3 знаками)
            File.WriteAllText(fullPath, value.ToString("F3"));

            // 4. Возвращаем путь
            return fullPath;
        }
    }
}