using Tyuiu.AymurzinaJV.Sprint3.Task1.V16.Lib;
namespace Tyuiu.AymurzinaJV.Sprint3.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(1, 1, 15);
            double wait = 16.936;
            Assert.AreEqual(wait, res);
        }
    }
}
