using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            // 1. Вычисляем значение функции F(x) = 0.7x^3 + 1.52x^2
            double value = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);

            // 2. Округляем ДО ДВУХ знаков
            value = Math.Round(value, 2);

            // 3. Путь к файлу во временной папке
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask0.txt";
            string fullPath = Path.Combine(tempDir, fileName);

            // 4. Записываем в файл строку с ДВУМЯ знаками после запятой
            // "F2" -> 2 знака (в русской культуре будет 11,68)
            File.WriteAllText(fullPath, value.ToString("F2"));

            // 5. Возвращаем путь к файлу
            return fullPath;
        }
    }
}