using Tyuiu.AymurzinaJV.Sprint3.Task2.V3.Lib;
namespace Tyuiu.AymurzinaJV.Sprint3.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSeries(4, 1, 15);
            double wait = 1935;

            Assert.AreEqual(wait, res);
        }
    }
}
