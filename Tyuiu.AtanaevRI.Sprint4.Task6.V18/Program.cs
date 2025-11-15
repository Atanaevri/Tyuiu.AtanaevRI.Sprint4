using Tyuiu.AtanaevRI.Sprint4.Task6.V18.Lib;
using System;


namespace Tyuiu.AtanaevRI.Sprint5.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Обработка строковых массивов                                      *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #18                                                           *");
            Console.WriteLine("* Выполнил: Атанаев Р.И. | Рппб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Собака\", \"Кошка\", \"Кролик\",           *");
            Console.WriteLine("* \"Хомяк\", \"Попугай\", \"Рыбка\", \"Черепаха\"]. Используя класс Array,   *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 6 символов.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Исходный массив
            string[] animals = {
                "Собака", "Кошка", "Кролик", "Хомяк",
                "Попугай", "Рыбка", "Черепаха"
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(animals);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string[] result = ds.Calculate(animals);

            Console.WriteLine("Элементы с длиной больше 6 символов:");
            PrintArray(result);

          
        }

        static void PrintArray(string[] array)
        {
            foreach (string element in array)
            {
                Console.WriteLine($"\"{element}\" (длина: {element.Length})");
            }
        }
    }
}