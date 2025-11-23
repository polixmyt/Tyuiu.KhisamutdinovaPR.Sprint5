using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double maxDivisibleByThree = double.MinValue;

            string content = File.ReadAllText(path);
            string[] numbers = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in numbers)
            {
                double value = Math.Round(Convert.ToDouble(str.Replace('.', ',')), 3);
                if (value % 3 == 0 && value > maxDivisibleByThree)
                {
                    maxDivisibleByThree = value;
                }
            }

            return Factorial((int)maxDivisibleByThree);
        }

        private double Factorial(int number)
        {
            double result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}