using Tyuiu.AymurzinaJV.Sprint3.Task7.V19.Lib;
namespace Tyuiu.AymurzinaJV.Sprint3.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;
            double[] wait = new double[11] {23.61, 16.08, 7.84, 4.58, 2.88, 0.75, -4.47, -9.46, -7.41, -6.16 , -7.29};

            CollectionAssert.AreEqual(ds.GetMassFunction(startvalue, stopvalue), wait);
        }
    }
}
