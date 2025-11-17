// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21
// Description: Чтение X из файла и вычисление y = x^3 * cos(x) + 2x.

using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        /// <summary>
        /// Считывает значение X из текстового файла, вычисляет
        /// y = x^3 * cos(x) + 2x, округляет до трёх знаков и возвращает результат.
        /// </summary>
        public double LoadFromDataFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу не должен быть пустым.", nameof(path));

            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            // читаем число X из файла
            string text = File.ReadAllText(path).Trim();

            // парсим с учётом запятой/точки
            double x = double.Parse(text, CultureInfo.CurrentCulture);

            // вычисляем выражение
            double y = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;

            // округляем до 3 знаков
            y = Math.Round(y, 3);

            return y;
        }
    }
}