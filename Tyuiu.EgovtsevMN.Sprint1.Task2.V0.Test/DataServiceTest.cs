using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint1.Task2.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x =(int)1.609;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(1 , res);


        }
    }
}
