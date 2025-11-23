using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task5.V14.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V14.txt");
            File.WriteAllText(path, "3\n6\n9\n");
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(362880.0, result, 0.001);
        }
    }
}