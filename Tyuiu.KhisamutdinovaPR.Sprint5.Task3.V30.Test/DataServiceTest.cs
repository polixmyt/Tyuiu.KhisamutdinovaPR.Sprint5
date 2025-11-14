// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30
// Description: Тест метода SaveToFileTextData для записи в бинарный файл.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Lib;

namespace Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_CreatesBinaryFile_WithCorrectValue()
        {
            // arrange
            int x = 3;
            DataService ds = new DataService();

            // ожидаемое значение
            double expected = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            expected = Math.Round(expected, 3);

            // act
            string path = ds.SaveToFileTextData(x);

            // assert: файл существует
            Assert.IsTrue(File.Exists(path), "Файл не был создан.");

            double actual;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                actual = br.ReadDouble();
            }

            Assert.AreEqual(expected, actual, 0.0001, "Значение в бинарном файле вычислено неверно.");
        }
    }
}