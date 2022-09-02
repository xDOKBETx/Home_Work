/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreateArray(int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(-10, 10);
        }
    }
    return array;
}
void PrintArray(double[,] plenty)
{
    for (int i = 0; i < plenty.GetLength(0); i++)
    {
        for (int j = 0; j < plenty.GetLength(1); j++)
        {
            Console.Write("{0,5:N1}", plenty[i, j]);
        }
        Console.WriteLine();
    }
}


Console.Write("Введите число строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Массив {m} x {n}: ");
PrintArray(CreateArray(m, n));
