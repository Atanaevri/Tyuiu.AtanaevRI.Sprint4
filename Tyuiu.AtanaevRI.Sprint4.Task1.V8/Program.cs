// See https://aka.ms/new-console-template for more information
using Tyuiu.AtanaevRI.Sprint4.Task1.V8.Lib;
DataService ds = new DataService();
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("*        Введите количество элементов массива                                   *");
len = Convert.ToInt32(Console.ReadLine());
int[] array =  new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine("*        Введите значение   " + i + "'элемента массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}


for (int i = 0; i < len; i++)
{
    Console.Write(array[i]+"/t");
}
    Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine(res);


