using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint6.Task0.V18.Lib;
namespace Tyuiu.KomarovMA.Sprint6.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1.056;
            Assert.AreEqual(wait, res);
        }
    }
}