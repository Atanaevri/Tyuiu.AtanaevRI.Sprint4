using Tyuiu.AtanaevRI.Sprint4.Task1.V8.Lib;
namespace Tyuiu.AtanaevRI.Sprint4.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };
            DataService ds = new DataService();
            int res = ds.Calculate(array);
            Assert.AreEqual(29, res);
        }
    }
}
