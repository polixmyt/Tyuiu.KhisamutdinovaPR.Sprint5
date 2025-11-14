using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_BinaryFileContainsRoundedString()
        {
            int x = 3;
            DataService ds = new DataService();

            // ожидаемое округлённое значение
            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            y = Math.Round(y, 3);
            string expected = y.ToString("F3");

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path), "Файл не был создан.");

            string fromFile;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                fromFile = br.ReadString();
            }

            Assert.AreEqual(expected, fromFile, "Строка в бинарном файле не совпадает с ожидаемой.");
        }
    }
}