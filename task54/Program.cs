/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/


// Пользователь вводит количество строк и столбцов, а также диапазон возможных значений для элементов массива.
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int last = Convert.ToInt32(Console.ReadLine());

// Функция, которая создает двумерный массив заданной размерности и заполняет его случайными числами из заданного диапазона.
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            // Используем класс Random для генерации случайных чисел в заданном диапазоне.
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

// Функция для вывода двумерного массива в консоль.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Выводим элементы массива через пробел.
            Console.Write($"{array[i, j]} ");
        }

        // После каждой строки выводим пустую строку.
        Console.WriteLine();
    }
}

// Функция для сортировки элементов каждой строки в двумерном массиве по убыванию.
void SelectionRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    // Если текущий элемент меньше следующего, меняем их местами.
                    temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
}

// Создаем двумерный массив и выводим его в консоль.
int[,] array = GetArray(row, col, first, last);
PrintArray(array);

// Сортируем каждую строку в массиве и выводим его в консоль.
Console.WriteLine();
SelectionRows(array);
PrintArray(array);
