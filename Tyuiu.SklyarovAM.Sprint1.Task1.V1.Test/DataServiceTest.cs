using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint1.Task1.V1.Lib;

namespace Tyuiu.SklyarovAM.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1;
            double x = 3;
            double y = -5;
            var res = ds.Calculate(a,x,y);
            Assert.AreEqual(1 ,res);
        }
    }
}
