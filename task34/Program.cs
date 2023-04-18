/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве. 
 [345, 897, 568, 234] -> 2
*/

using System;

class Program
{
    // Метод для создания массива случайных трехзначных чисел
    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        int[] array = new int[size];

        // Инициализация генератора случайных чисел
        Random random = new Random();

        // Заполнение массива случайными числами в заданном диапазоне
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        // Вывод элементов массива в квадратных скобках через запятую
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            // Добавление запятой и пробела между элементами, кроме последнего
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");

        // Переход на новую строку
        Console.WriteLine();
    }

    // Метод для подсчета количества четных элементов в массиве
    static int CountEvenElements(int[] array)
    {
        int count = 0;

        // Проход по всем элементам массива
        for (int i = 0; i < array.Length; i++)
        {
            // Проверка, является ли текущий элемент четным
            if (array[i] % 2 == 0)
            {
                // Увеличение счетчика четных элементов
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        // Запрос размера массива у пользователя
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Создание массива случайных трехзначных чисел
        int[] array = GenerateRandomArray(size, 100, 999);

        // Вывод массива на экран
        PrintArray(array);

        // Подсчет количества четных элементов в массиве и вывод результата на экран
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных чисел = {evenCount}");
    }
}
