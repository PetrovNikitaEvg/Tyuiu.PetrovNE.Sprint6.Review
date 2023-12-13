using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint6.TaskReview.V4.Lib;

namespace Tyuiu.PetrovNE.Sprint6.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int k = 2, l = 3, c = 1;
            int[,] array = new int[4, 5] { { 15,      10,      9,      6,       11 },
                                            {11,      12,      17 ,     2,       13, },
                                            { 13,      18,      15,      2,       3},
                                            { 7,       6,       17,      14,      1}};
            double Result = ds.Result(array, c, k, l);
            int wait = 24;
            Assert.AreEqual(wait, Result);
        }
    }
}
