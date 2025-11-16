using Tyuiu.AtanaevRI.Sprint4.Task7.V25.Lib;
using System;
using Tyuiu.AtanaevRI.Sprint4.Task7.V25.Lib;

namespace Tyuiu.AtanaevRI.Sprint4.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Спринт #4 | Выполнил: Атанаев Р.И. | Рппб-25-1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 4 на 3    *");
            Console.WriteLine("* и подсчитайте сумму четных чисел.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            string value = "348561792486";

            Console.WriteLine($"Количество строк (n) = {n}");
            Console.WriteLine($"Количество столбцов (m) = {m}");
            Console.WriteLine($"Исходная строка = {value}");

           
            int[,] matrix = CreateMatrixFromString(n, m, value);

            Console.WriteLine("\nПолученная матрица:");
            PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(n, m, value);
            Console.WriteLine($"Сумма четных чисел в матрице = {result}");

         
            Console.WriteLine("\nДетализация расчета:");
            PrintCalculationDetails(matrix);

           
        }

        
        static int[,] CreateMatrixFromString(int n, int m, string value)
        {
            if (value.Length != n * m)
            {
                throw new ArgumentException("Длина строки не соответствует размеру матрицы");
            }

            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            return matrix;
        }

        
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        
        static void PrintCalculationDetails(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;
            bool first = true;

            Console.Write("Четные числа: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        if (!first)
                        {
                            Console.Write(" + ");
                        }
                        Console.Write(matrix[i, j]);
                        sum += matrix[i, j];
                        first = false;
                    }
                }
            }

            Console.WriteLine($" = {sum}");
        }
    }
}