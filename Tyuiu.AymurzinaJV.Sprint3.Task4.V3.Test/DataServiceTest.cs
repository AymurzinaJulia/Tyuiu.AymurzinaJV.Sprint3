using Tyuiu.AymurzinaJV.Sprint3.Task4.V3.Lib;
namespace Tyuiu.AymurzinaJV.Sprint3.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 1.067;
            Assert.AreEqual(wait, ds.Calculate(-5, 5));
        }
    }
}
