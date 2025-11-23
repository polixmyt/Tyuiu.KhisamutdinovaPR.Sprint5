using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;

            if (filexists)
            {
                File.Delete(path);
            }

            double x1 = Convert.ToDouble(x);

            double res = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            res = Math.Round(res, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}