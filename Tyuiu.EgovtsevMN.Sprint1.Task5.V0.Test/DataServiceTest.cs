using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint1.Task5.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint1.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            int result = Convert.ToInt32(res);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}
