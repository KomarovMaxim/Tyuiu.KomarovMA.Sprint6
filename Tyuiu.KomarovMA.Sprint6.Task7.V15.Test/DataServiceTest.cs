using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint6.Task7.V15.Lib;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void File()
        {
            string path = @"D:\SOURSE\Tyuiu.KomarovMA.Sprint6\Tyuiu.KomarovMA.Sprint6.Task7.V15\bin\Debug\InPutFileTask7V15.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
