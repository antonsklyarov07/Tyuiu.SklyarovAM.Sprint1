using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint1.Task7.V2.Lib;
namespace Tyuiu.SklyarovAM.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();
            double x = 12;
            double y = 45;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1 , res);
        }
    }
}
