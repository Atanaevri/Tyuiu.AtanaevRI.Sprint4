// See https://aka.ms/new-console-template for more information
using Tyuiu.AtanaevRI.Sprint4.Task4.V12.Lib;




namespace Tyuiu.AtanaevRI.Sprint4.Task4.V12
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                DataService ds = new DataService();

                Console.WriteLine("Введите элементы массива 5x5 (числа от 2 до 8):");
                int[,] array = new int[5, 5];

                // Ввод массива
                InputArray(array);

                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                // Вывод исходного массива
                Console.WriteLine("Исходный массив:");
                PrintArray(array);

                // Обработка массива
                int[,] result = ds.Calculate(array);

                // Вывод результата
                Console.WriteLine("Обработанный массив (четные заменены на 1):");
                PrintArray(result);

                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСПЕШНО ЗАВЕРШЕНО                                                       *");
                Console.WriteLine("***************************************************************************");
                Console.ReadKey();
            }

            static void InputArray(int[,] array)
            {
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        while (true)
                        {
                            Console.Write($"Элемент [{i},{j}]: ");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out int number))
                            {
                                if (DataService.IsInRange(number))
                                {
                                    array[i, j] = number;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка: число должно быть от 2 до 8!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: введите целое число!");
                            }
                        }
                    }
                }
            }

            static void PrintArray(int[,] array)
            {
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }