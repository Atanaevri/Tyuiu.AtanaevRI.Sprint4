using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AtanaevRI.Sprint4.Task4.V12.Lib
{
    
        

    
        public class DataService : ISprint4Task4V12
        {
            public int[,] Calculate(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] % 2 == 0)
                        {
                            matrix[i, j] = 1;
                        }
                    }
                }
                return matrix;
            }

            
            public static bool IsInRange(int number)
            {
                return number >= 2 && number <= 8;
            }
        }
    }







