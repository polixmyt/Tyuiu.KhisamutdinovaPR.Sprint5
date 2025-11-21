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
        public string SaveToFileTextData(int x)
        {
            // 1. Вычисляем значение y = (x^3 - 1) / (4 * x^2)
            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));

            // 2. Округляем до трёх знаков
            y = Math.Round(y, 3);

            // 3. Формируем путь к бинарному файлу во временной папке
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string fullPath = Path.Combine(tempDir, fileName);

            // 4. Записываем значение как float (Single) в бинарный файл
            using (FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write((float)y);
            }

            // 5. Возвращаем путь к файлу
            return fullPath;
        }
    }
}