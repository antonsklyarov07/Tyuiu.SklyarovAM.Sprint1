using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SklyarovAM.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 136789;
            int res = ds.Calculate(k);
            Assert.AreEqual(7, res);
        }
    }
}
