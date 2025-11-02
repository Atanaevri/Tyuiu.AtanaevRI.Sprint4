
using Tyuiu.AtanaevRI.Sprint4.Task0.V10.Lib;
namespace Tyuiu.AtanaevRI.Sprint4.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetSumOddArrEl(array);
            Assert.AreEqual(43, res);
        }
        }
    }
}
