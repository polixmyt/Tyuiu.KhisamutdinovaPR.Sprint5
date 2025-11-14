// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26
// Description: Тест метода SaveToFileTextData.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_CreatesFile_WithCorrectValue()
        {
            // arrange
            int x = 2;
            DataService ds = new DataService();

            double expected = Math.Round(
                0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2),
                3);

            // act
            string path = ds.SaveToFileTextData(x);

            // assert: файл существует
            Assert.IsTrue(File.Exists(path), "Файл не был создан.");

            string text = File.ReadAllText(path);

            // парсим с текущей культурой (запятая/точка)
            double actual = double.Parse(text, CultureInfo.CurrentCulture);

            Assert.AreEqual(expected, actual, 0.0001, "Значение функции записано неверно.");
        }
    }
}