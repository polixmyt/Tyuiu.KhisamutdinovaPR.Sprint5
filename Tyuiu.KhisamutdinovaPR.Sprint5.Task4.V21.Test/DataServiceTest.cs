using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFormula()
        {
            // создаём временный файл
            string temp = Path.GetTempFileName();
            File.WriteAllText(temp, "4.68", CultureInfo.InvariantCulture);

            DataService ds = new DataService();

            double x = 4.68;
            double expected = Math.Round(Math.Pow(x, 3) * Math.Cos(x) + 2 * x, 3);

            double actual = ds.LoadFromDataFile(temp);

            Assert.AreEqual(expected, actual);
        }
    }
}