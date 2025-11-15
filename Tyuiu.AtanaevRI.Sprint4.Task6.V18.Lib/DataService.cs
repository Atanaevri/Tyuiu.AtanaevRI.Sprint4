using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AtanaevRI.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {
           
            {
                
                int count = 0;

               
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length > 6)
                    {
                        count++;
                    }
                }

               
                string[] result = new string[count];
                int index = 0;

               
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length > 6)
                    {
                        result[index] = array[i];
                        index++;
                    }
                }

                return result;
            }
        }
    }
}
    
        
