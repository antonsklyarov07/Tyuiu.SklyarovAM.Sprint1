using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint1.Task6.V9.Lib;

namespace Tyuiu.SklyarovAM.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "1234127";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(strTest);
            Assert.AreEqual( "7123412", res );
        }
    }
}
