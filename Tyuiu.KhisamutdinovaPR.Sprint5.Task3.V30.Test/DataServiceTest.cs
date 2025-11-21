// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30
// Description: Тест метода SaveToFileTextData — проверка значения в бинарном файле.

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
        public void SaveToFileTextData_WriteFloatAndCheckValue()
        {
            // arrange
            DataService ds = new DataService();
            int x = 3;

            double expected = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            expected = Math.Round(expected, 3);

            // act
            string path = ds.SaveToFileTextData(x);

            // assert
            Assert.IsTrue(File.Exists(path), "Файл не был создан.");

            float fromFile;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                fromFile = br.ReadSingle();
            }

            Assert.AreEqual((float)expected, fromFile, 0.0001f, "Значение в файле не совпадает с ожидаемым.");
        }
    }
}