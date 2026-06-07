using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint1.Task3.V1.Lib;

namespace Tyuiu.SklyarovAM.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 10;
            double h = 5;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(1570, res);
        }
    }
}
