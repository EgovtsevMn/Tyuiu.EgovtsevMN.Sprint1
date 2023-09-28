using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EgovtsevMN.Sprint1.Task6.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "a b c 1 2 3 d";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);


        }
    }
}
