using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            try
            {
                // Чтение содержимого файла
                string[] lines = File.ReadAllLines(path);

                double sum = 0;

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    if (double.TryParse(trimmedLine, NumberStyles.Float, CultureInfo.GetCultureInfo("ru-RU"), out double number))
                    {
                        // Вычисление по формуле для текущего числа
                        double y = Math.Pow(number, 3) * Math.Cos(number) + 2 * number;

                        // Суммируем результат (если требуется вывести сумму)
                        sum += Math.Round(y, 3);
                    }
                    else
                    {
                        throw new FormatException($"Строка '{line}' невозможно преобразовать в число.");
                    }
                }

                return sum; // Или возвращайте другие вычисления, если это необходимо
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла или вычислении.", ex);
            }
        }
    }
}