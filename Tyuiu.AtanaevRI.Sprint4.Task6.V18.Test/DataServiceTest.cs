using Tyuiu.AtanaevRI.Sprint4.Task6.V18.Lib;

namespace Tyuiu.AtanaevRI.Sprint4.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                DataService ds = new DataService();

                string[] inputArray = {
                "Собака", "Кошка", "Кролик", "Хомяк",
                "Попугай", "Рыбка", "Черепаха"
            };

                string[] result = ds.Calculate(inputArray);
                string[] wait = { "Попугай", "Черепаха" }; 
                CollectionAssert.AreEqual(wait, result);
            }
        }
    }

   

