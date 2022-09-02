/* Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
double ArithmeticMean(int[,] array, int indexColumn)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, indexColumn];
    }
    return (double) sum / (array.GetLength(0));
}

int rowArray = new Random().Next(1, 10);
int columnArray = new Random().Next(1, 10);
int[,] plenty = CreateArray(rowArray, columnArray);

Console.WriteLine($"Массив {rowArray}x{columnArray}:");
PrintArray(plenty);

Console.Write($"Среднее арифметическое каждого столбца:");
for (int i = 0; i < columnArray; i++)
{
    Console.Write($" {Math.Round(ArithmeticMean(plenty, i), 1)} ");
}
