using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        /// <summary>
        /// Табулирует функцию
        /// F(x) = (2*cos(x) + 2) / (2*x - 1) + cos(x) - 5*x + 3
        /// на отрезке [startValue; stopValue] с шагом 1,
        /// проверяет деление на ноль (если 2*x - 1 == 0, то f(x) = 0),
        /// записывает результаты в текстовый файл OutPutFileTask1.txt
        /// во временной папке и возвращает путь к файлу.
        /// Значения округляются до двух знаков после запятой.
        /// </summary>
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Формируем путь к файлу во временной директории
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string fullPath = Path.Combine(tempDir, fileName);

            // Массив строк для записи в файл
            int length = stopValue - startValue + 1;
            string[] lines = new string[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;

                double denominator = 2 * x - 1;

                // Проверка деления на ноль
                if (denominator == 0)
                {
                    fx = 0;
                }
                else
                {
                    fx = (2 * Math.Cos(x) + 2) / denominator
                         + Math.Cos(x)
                         - 5 * x
                         + 3;
                }

                // Округляем до двух знаков
                fx = Math.Round(fx, 2);

                // В файл пишем только значение функции (по одному на строку)
                // Формат с двумя знаками после запятой, например: 28,05
                lines[index] = fx.ToString("F2");
                index++;
            }

            // Записываем все строки в файл
            File.WriteAllLines(fullPath, lines);

            // Возвращаем путь к созданному файлу
            return fullPath;
        }
    }
}