using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AtanaevRI.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colum = array.Length / rows;
            int sum = 0;
            for (int i = 0;i < rows;i++)
            {
               
                   
                   sum = sum + array[i, 1];
                    
                
      
            }
            return sum;
        }
    }
}
