using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            // 1. Вычисляем выражение y = (x^3 - 1) / (4 * x^2)
            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));

            // 2. Округляем до трёх знаков
            y = Math.Round(y, 3);

            // 3. Получаем временную папку и имя файла
            string tempDir = Path.GetTempPath();              // ВАЖНО: никакого "C:\\Temp"
            string fileName = "OutPutFileTask3.bin";

            // 4. Собираем полный путь
            string fullPath = Path.Combine(tempDir, fileName);

            // 5. Записываем значение как float (Single) в бинарный файл
            using (FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write((float)y);
            }

            // 6. Возвращаем путь к файлу
            return fullPath;
        }
    }
}