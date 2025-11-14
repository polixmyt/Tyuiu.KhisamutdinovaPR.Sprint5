using System;
using System.IO;
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

            int length = stopValue - startValue + 1;
            string[] lines = new string[length];

            int index = 0;

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

                // каждая строка — только F(x) с двумя знаками
                lines[index] = fx.ToString("F2");
                index++;
            }

            // ВАЖНО: записываем одной строкой без лишнего перевода строки в конце
            string text = string.Join(Environment.NewLine, lines);
            File.WriteAllText(fullPath, text);

            return fullPath;
        }
    }
}