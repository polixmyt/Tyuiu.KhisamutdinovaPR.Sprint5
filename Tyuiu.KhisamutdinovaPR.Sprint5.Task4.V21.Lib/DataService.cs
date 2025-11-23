using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib

{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            double strX = Convert.ToDouble(File.ReadAllText(path).Replace('.', ','));
            double res = Math.Round((Math.Pow(Convert.ToDouble(strX), 3) * Math.Cos(Convert.ToDouble(strX)) + 2 * (Convert.ToDouble(strX))), 3);
            return res;
        }
    }
}