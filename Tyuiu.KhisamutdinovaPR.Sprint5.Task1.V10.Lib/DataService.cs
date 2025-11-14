using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string fullPath = Path.Combine(tempDir, fileName);

            StringBuilder sb = new StringBuilder();

            bool firstLine = true;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 1;
                double fx;

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

                fx = Math.Round(fx, 2);

                // === КЛЮЧЕВОЙ МОМЕНТ ===
                // Если значение стало ровно 0 — пишем просто "0"
                // Иначе пишем с двумя знаками после запятой ("F2")
                string line;
                if (Math.Abs(fx) < 1e-9)
                {
                    line = "0";
                }
                else
                {
                    line = fx.ToString("F2");
                }

                // Добавляем перевод строки ТОЛЬКО между строками, а не после последней
                if (!firstLine)
                {
                    sb.AppendLine();
                }
                sb.Append(line);
                firstLine = false;
            }

            File.WriteAllText(fullPath, sb.ToString());

            return fullPath;
        }
    }
}