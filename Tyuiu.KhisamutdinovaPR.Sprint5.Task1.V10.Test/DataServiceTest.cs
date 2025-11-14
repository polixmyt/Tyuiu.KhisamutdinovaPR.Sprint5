using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task1.V10.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_CreatesFile_AndCorrectLinesCount()
        {
            // arrange
            int start = -5;
            int stop = 5;
            DataService ds = new DataService();

            // act
            string path = ds.SaveToFileTextData(start, stop);

            // assert
            Assert.IsTrue(File.Exists(path), "Файл не был создан.");

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(stop - start + 1, lines.Length, "Неверное количество строк в файле.");
        }

        [TestMethod]
        public void SaveToFileTextData_CheckSampleValue()
        {
            // проверим, например, x = -5 (первая строка)
            int start = -5;
            int stop = 5;
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(start, stop);
            string[] lines = File.ReadAllLines(path);

            // вычисляем ожидаемое значение отдельно
            int x = -5;
            double denominator = 2 * x - 1;
            double fx;

            if (denominator == 0)
            {
                fx = 0;
            }
            else
            {
                fx = (2 * Math.Cos(x) + 2) / denominator
                     + Math.Cos(x)
                     - 5 * x
                     + 3;
            }

            fx = Math.Round(fx, 2);

            double actualFromFile = double.Parse(lines[0], CultureInfo.CurrentCulture);

            Assert.AreEqual(fx, actualFromFile, 0.01, "Значение функции для x = -5 записано неверно.");
        }
    }
}