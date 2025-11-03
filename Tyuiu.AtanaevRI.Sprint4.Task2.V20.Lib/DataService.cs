using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AtanaevRI.Sprint4.Task2.V20.Lib
{
    public class DataService : ISprint4Task2V20
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];

                }
            }
            return sum;
        }
    }
}
