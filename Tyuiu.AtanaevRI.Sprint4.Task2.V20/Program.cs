// See https://aka.ms/new-console-template for more information
using Tyuiu.AtanaevRI.Sprint4.Task2.V20.Lib;
DataService ds = new DataService();
Random rnd = new Random();





Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("*        Введите количество элементов массива                                   *");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

for (int i = 0; i < len; i++)
{
    array[i] = rnd.Next(2,7);
}

Console.WriteLine("Массив");
for (int i = 0; i < len; i++)
{
    Console.Write(array[i] );
}


Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine(res);
