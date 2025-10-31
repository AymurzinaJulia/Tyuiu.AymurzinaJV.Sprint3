using Tyuiu.AymurzinaJV.Sprint3.Task6.V2.Lib;
namespace Tyuiu.AymurzinaJV.Sprint3.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 12;
            int stopValue = 18;
            int wait = 29;
            Assert.AreEqual(wait, ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}
