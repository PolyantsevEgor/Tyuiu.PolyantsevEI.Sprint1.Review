using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint1.TaskReview.V7.Lib;

namespace Tyuiu.PolyantsevEI.Sprint1.TaskReview.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = Math.PI;
            double wait = -1.124;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
