using Tyuiu.AtanaevRI.Sprint4.Task5.V1.Lib;
namespace Tyuiu.AtanaevRI.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                DataService ds = new DataService();

                int[,] matrix = new int[5, 5]
                {
                { -9, 8, 7, 6, 5 },
                { -8, -7, -6, -5, -4 },
                { 4, 5, 6, 7, 8 },
                { -1, 2, -3, 4, -5 },
                { 0, -2, 3, -4, 5 }
                };

                int[,] res = ds.Calculate(matrix);

                int[,] wait = new int[5, 5]
                {
                { -9, 1, 1, 1, 1 },
                { -8, -7, -6, -5, -4 },
                { 1, 1, 1, 1, 1 },
                { -1, 1, -3, 1, -5 },
                { 0, -2, 1, -4, 1 }
                };

                CollectionAssert.AreEqual(wait, res);
            }
        }
    }

   

