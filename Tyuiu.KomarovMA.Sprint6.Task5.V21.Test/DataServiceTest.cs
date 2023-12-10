using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint6.Task5.V21.Lib;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint6.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\SOURSE\Tyuiu.KomarovMA.Sprint6\Tyuiu.KomarovMA.Sprint6.Task6.V21\bin\Debug\InPutFileTask5V21.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
