using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        // Вычисляет y = (x^3 - 1) / (4 * x^2),
        // округляет до 3 знаков, записывает ОКРУГЛЁННОЕ значение
        // как строку в бинарный файл OutPutFileTask3.bin
        // и возвращает путь к файлу.
        public string SaveToFileTextData(int x)
        {
            // 1. Вычисляем выражение
            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));

            // 2. Округляем до 3 знаков
            y = Math.Round(y, 3);

            // 3. Переводим в строку с 3 знаками
            string valueString = y.ToString("F3");

            // 4. Формируем путь к бинарному файлу во временной папке
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string fullPath = Path.Combine(tempDir, fileName);

            // 5. Пишем строку в бинарный файл
            using (FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(valueString);    // <<< пишем СТРОКУ, а не double
            }

            return fullPath;
        }
    }
}