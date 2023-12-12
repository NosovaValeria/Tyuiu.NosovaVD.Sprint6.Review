using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint6.TaskReview.V8.Lib;
namespace Tyuiu.NosovaVD.Sprint6.TaskReview.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            int k = 2;
            int l = 3;
            int c = 4;
            DataService ds = new DataService();
            int[,] array = new int[5, 5]  { { 4, -3, 6, -5, 5},
                                            { 3, -54, 4, -6, 4 },
                                            { 6, -4, 6, -4, 5 },
                                            { 5, -4, 4, -4, 5 },
                                            { 3, -5, 6, -4, 6 }}; 
            int res = ds.resultGetMatrix(array, c, k, l);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}
