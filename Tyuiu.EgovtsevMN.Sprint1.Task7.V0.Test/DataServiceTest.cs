using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint1.Task7.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint1.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(0.978, res);
        }
    }
}
