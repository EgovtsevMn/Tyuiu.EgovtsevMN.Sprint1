using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint1.Task3.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double length = 9;
            double width = 7.5;
            double height = 5;
            double wait = 337.5;
            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(wait, res);
        }
    }
}
