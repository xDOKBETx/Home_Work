/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив размером 5х5
        int[,] myArray = new int[5, 5];
        // Создаем объект Random для генерации случайных чисел
        Random rand = new Random();

        // Заполняем массив случайными числами и выводим его на экран
        Console.WriteLine("Созданный массив:");
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                // Генерируем случайное число и записываем его в элемент массива
                myArray[i, j] = rand.Next(10);
                // Выводим значение элемента массива на экран
                Console.Write(myArray[i, j] + " ");
            }
            // Переходим на следующую строку после вывода элементов строки массива
            Console.WriteLine();
        }

        // Получаем позицию элемента от пользователя
        Console.WriteLine("Введите позицию элемента в формате \"строка,столбец\":");
        string[] position = Console.ReadLine().Split(',');
        int row = int.Parse(position[0]);
        int column = int.Parse(position[1]);

        // Проверяем, что указанные позиции не выходят за границы массива
        if (row >= myArray.GetLength(0) || column >= myArray.GetLength(1))
        {
            Console.WriteLine("Указанный элемент не существует в массиве.");
        }
        else
        {
            // Получаем значение элемента и выводим его на экран
            int element = myArray[row, column];
            Console.WriteLine($"Значение элемента: {element}");
        }

        Console.ReadLine();
    }
}
