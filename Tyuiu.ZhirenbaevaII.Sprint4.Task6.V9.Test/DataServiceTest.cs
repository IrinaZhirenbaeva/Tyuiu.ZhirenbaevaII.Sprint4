using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint4.Task6.V9.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            {
                DataService ds = new DataService();
                var color = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
                int res = ds.Calculate(color);
                int wait = 3;
                Assert.AreEqual(wait, res);
            }
        }
    }
}
    

