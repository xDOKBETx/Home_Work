/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/


// Выводим сообщение на консоль и считываем количество строк
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

// Выводим сообщение на консоль и считываем количество столбцов
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

// Выводим сообщение на консоль и считываем начало диапазона
Console.Write("Введите начало диапазона: ");
int first = Convert.ToInt32(Console.ReadLine());

// Выводим сообщение на консоль и считываем конец диапазона
Console.Write("Введите конец диапазона: ");
int last = Convert.ToInt32(Console.ReadLine());

// Метод для создания двумерного массива с заданным количеством строк и столбцов, 
// и заполнением его случайными числами в заданном диапазоне
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); // Заполняем ячейку случайным числом из заданного диапазона
        }
    }

    return result;
}

// Метод для вывода двумерного массива на консоль
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} "); // Выводим элементы массива через пробел
        }
        Console.WriteLine(); // Переходим на новую строку
    }
}

// Метод для нахождения индекса строки двумерного массива с наименьшей суммой элементов
int RowMinimumSum(int[,] array)
{
    int minIndex = 0;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; // Считаем сумму элементов текущей строки
        }
        if (minSum > sum || minSum <= 0) // Если текущая сумма меньше минимальной или минимальной нет, то обновляем минимальную сумму и индекс строки
        {
            minSum = sum;
            minIndex = i;
        }
    }
    return minIndex;
}

// Создаем двумерный массив и выводим его на консоль
int[,] array = GetArray(row, col, first, last);
PrintArray(array);

// Находим индекс строки с наименьшей суммой элементов и выводим его на консоль
Console.WriteLine();
Console.Write($"Индекс строки двумерного массива с наименьшей суммой элементов: {RowMinimumSum(array)}");
