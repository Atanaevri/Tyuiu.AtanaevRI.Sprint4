using Tyuiu.AtanaevRI.Sprint4.Task5.V1.Lib;


            Console.Title = "Спринт #4 | Выполнил: Атанаев Р. И. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                         *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -9 до 8. Заменить положительные   *");
            Console.WriteLine("* элементы массива на 1.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] array = new int[5, 5];
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(-9, 9); 
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] res = ds.Calculate(array);

            Console.WriteLine("Массив после замены положительных элементов на 1:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}