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
            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            y = Math.Round(y, 3);

            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";

            // ПРАВИЛЬНЫЙ путь
            string fullPath = Path.Combine(tempDir, fileName);

            using (FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write((float)y);
            }

            // ВОЗВРАЩАТЬ ТОЛЬКО путь, БЕЗ \n, БЕЗ пробелов
            return fullPath.Trim();
        }

    }
}