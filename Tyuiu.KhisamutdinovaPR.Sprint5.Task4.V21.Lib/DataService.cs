using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string text = File.ReadAllText(path).Trim();

            // читаем X
            double x = double.Parse(text, CultureInfo.InvariantCulture);

            // формула по варианту 21
            double y = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;

            // округление
            y = Math.Round(y, 3);

            return y;
        }
    }
}