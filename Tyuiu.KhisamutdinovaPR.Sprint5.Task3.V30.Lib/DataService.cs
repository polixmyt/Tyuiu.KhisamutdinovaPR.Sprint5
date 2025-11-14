// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30
// Description: Вычисление выражения и сохранение результата в бинарный файл.

using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        /// <summary>
        /// Вычисляет значение y = (x^3 - 1) / (4 * x^2),
        /// округляет до трёх знаков после запятой,
        /// сохраняет в бинарный файл OutPutFileTask3.bin
        /// во временной папке и возвращает путь к файлу.
        /// </summary>
        public string SaveToFileTextData(int x)
        {
            // 1. Вычисление выражения
            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            y = Math.Round(y, 3);

            // 2. Формируем путь к бинарному файлу
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string fullPath = Path.Combine(tempDir, fileName);

            // 3. Записываем значение в бинарный файл
            using (FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(y);
            }

            // 4. Возвращаем путь
            return fullPath;
        }
    }
}