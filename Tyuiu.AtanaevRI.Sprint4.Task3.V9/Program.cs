// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations.Schema;
using Tyuiu.AtanaevRI.Sprint4.Task3.V9.Lib;
DataService ds = new DataService();
int[,] data = new int[,] { {9, 6, 4, 5, 3 },
                {7, 4, 7, 5, 3 }, {8, 5, 9, 9, 3 }, {7, 8, 7, 9, 3 },{ 3, 7, 3, 7, 7 } };

int rows = data.GetUpperBound(0) + 1;
int colum = data.Length / rows;

Console.WriteLine("Массив");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colum; j++)
    {
        Console.Write($"{data[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("Результат");

int res = ds.Calculate(data);


Console.WriteLine(res);
