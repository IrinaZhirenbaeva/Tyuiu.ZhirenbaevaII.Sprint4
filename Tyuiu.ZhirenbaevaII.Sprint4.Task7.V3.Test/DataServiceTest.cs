using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint4.Task7.V3.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint4.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            {
                DataService ds = new DataService();

                int rows = 4;
                int columns = 2;
                int[,] mtrx = new int[rows, columns];
                string str = "27182818";
                int res = ds.Calculate(rows, columns, str);
                int wait = 3;
                Assert.AreEqual(wait, res);
            }
        }
    }
}
    

