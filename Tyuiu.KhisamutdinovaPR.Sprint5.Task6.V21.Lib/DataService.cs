using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == 'т' && line[i + 1] == 'т')
                        {
                            count++;
                        }
                        if (line[i] == 'Т' && line[i + 1] == 'т')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}