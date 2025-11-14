using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task2.V13.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_ReplaceOddsAndSaveCsv()
        {
            // пример из условия:
            // 7  6  5
            // 7  7  8
            // 6  6  9
            int[,] matrix =
            {
                { 7, 6, 5 },
                { 7, 7, 8 },
                { 6, 6, 9 }
            };

            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path), "Файл не был создан.");

            string[] lines = File.ReadAllLines(path);

            // после замены нечётных на 0 должно быть:
            // 0 6 0
            // 0 0 8
            // 6 6 0
            Assert.AreEqual("0;6;0", lines[0]);
            Assert.AreEqual("0;0;8", lines[1]);
            Assert.AreEqual("6;6;0", lines[2]);
        }
    }
}