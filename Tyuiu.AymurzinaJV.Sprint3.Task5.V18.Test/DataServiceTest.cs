﻿using Tyuiu.AymurzinaJV.Sprint3.Task5.V18.Lib;
namespace Tyuiu.AymurzinaJV.Sprint3.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;
            double wait = 768.361;
            Assert.AreEqual(wait, ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}
