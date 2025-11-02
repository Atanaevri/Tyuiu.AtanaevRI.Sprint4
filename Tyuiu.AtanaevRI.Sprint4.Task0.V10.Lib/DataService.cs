using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AtanaevRI.Sprint4.Task0.V10.Lib
{
    [TestClass]
    public sealed class DataService : ISprint4Task0V10
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum = sum + array[i];
                }
            }
            return sum;
        }

        
    }
}
