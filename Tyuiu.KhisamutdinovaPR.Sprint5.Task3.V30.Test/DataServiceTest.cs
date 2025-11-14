// Author: Хисамутдинова Полина
// Project: Tyuiu.KhisamutdinovaPR.Sprint5.Task3.V30
// Description: Тест бинарной записи результата (float).

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
        public void CheckBinaryFloatWrite()
        {
            DataService ds = new DataService();
            int x = 3;

            double expected = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            expected = Math.Round(expected, 3);

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path), "Файл не создан.");

            // Читаем как float
            float actual;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                actual = br.ReadSingle();
            }

            Assert.AreEqual((float)expected, actual, 0.0001f, "Ошибка: значение не совпадает.");
        }
    }
}