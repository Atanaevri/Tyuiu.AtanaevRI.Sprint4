// See https://aka.ms/new-console-template for more information

using Tyuiu.AtanaevRI.Sprint4.Task0.V10.Lib;
DataService ds =   new DataService();
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}                                                       *");
for (int i = 0; i < array.Length;i++)
{
    Console.WriteLine(array[i]+"/t");
}



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.GetSumOddArrEl(array);
Console.WriteLine(res);


