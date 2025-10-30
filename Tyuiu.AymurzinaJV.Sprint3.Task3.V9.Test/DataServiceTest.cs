using Tyuiu.AymurzinaJV.Sprint3.Task3.V9.Lib;

namespace Tyuiu.AymurzinaJV.Sprint3.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = "wwhy vfewrw vfwwb";
            Assert.AreEqual(wait, ds.ReplaceNumOnChar("56hy vfe4r4 vf45b", 'w'));
        }
    }
}
