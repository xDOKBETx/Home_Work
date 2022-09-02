/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] CreateArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] plenty)
{
    for (int i = 0; i < plenty.GetLength(0); i++)
    {
        for (int j = 0; j < plenty.GetLength(1); j++)
        {
            Console.Write($"{plenty[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int rowArray = new Random().Next(1, 10);
int columnArray = new Random().Next(1, 10);
int[,] plenty = CreateArray(rowArray, columnArray);

Console.Write("Введите номер строки элемента массиве: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента в массиве: ");
int numColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Массив {rowArray}x{columnArray}: ");
PrintArray(plenty);

if (numRow > rowArray || numColumn > columnArray)
{
    Console.WriteLine($"Элемента с координатами {numRow}x{numColumn} в массиве нет");
}
else
{
    Console.WriteLine($"Элемент массива с координатами {numRow}x{numColumn} = {plenty[numRow - 1, numColumn - 1]}");
}

