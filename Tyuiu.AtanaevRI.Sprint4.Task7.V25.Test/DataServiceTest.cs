using Tyuiu.AtanaevRI.Sprint4.Task7.V25.Lib;
namespace Tyuiu.AtanaevRI.Sprint4.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            string value = "348561792486";

            int result = ds.Calculate(n, m, value);
            int wait = 38;

            Assert.AreEqual(wait, result);

        }    }
}
    

