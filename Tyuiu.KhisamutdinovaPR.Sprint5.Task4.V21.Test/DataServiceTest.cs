// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task4.V21
// Description: Тест вычисления y = x^3 * cos(x) + 2x из файла.

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
        public void LoadFromDataFile_CalcWith4_68()
        {
            // arrange: создаём временный файл с числом 4,68
            string tempFile = Path.GetTempFileName();

            double x = 4.68;
            string xText = x.ToString(CultureInfo.CurrentCulture);
            File.WriteAllText(tempFile, xText);

            DataService ds = new DataService();

            // ожидаемое значение по формуле
            double expected = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;
            expected = Math.Round(expected, 3);   // ≈ 6.041

            // act
            double actual = ds.LoadFromDataFile(tempFile);

            // assert
            Assert.AreEqual(expected, actual, 0.0001,
                "Результат вычисления по формуле неверен.");
        }
    }
}