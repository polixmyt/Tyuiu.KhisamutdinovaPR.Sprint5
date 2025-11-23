using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30

    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double y = Math.Round((Math.Pow(x, 3) - 1) / (4 * x * x), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}