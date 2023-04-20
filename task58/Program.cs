/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

using System;

class MatrixMultiplication
{
    // Функция для генерации матрицы заданного размера со случайными значениями в диапазоне от minValue до maxValue.
    static int[,] GenerateMatrix(int rows, int columns, int minValue, int maxValue)
    {
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }

        return matrix;
    }

    // Функция для вывода матрицы в консоль.
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Функция для умножения двух матриц.
    static int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

        // Для каждой строки первой матрицы...
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            // Для каждого столбца второй матрицы...
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                // Вычисляем элемент результирующей матрицы как сумму произведений элементов
                // i-й строки первой матрицы и j-го столбца второй матрицы.
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        // Генерируем две матрицы.
        int[,] matrixA = GenerateMatrix(4, 2, 0, 10);
        int[,] matrixB = GenerateMatrix(2, 5, 0, 10);

        // Проверяем, можно ли умножить эти матрицы.
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("Matrix multiplication is not possible!");
        }
        else
        {
            // Умножаем матрицы.
            int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

            // Выводим матрицы и результат на экран.
            Console.WriteLine("Matrix A:");
            PrintMatrix(matrixA);
            Console.WriteLine("Matrix B:");
            PrintMatrix(matrixB);
            Console.WriteLine("Result matrix:");
            PrintMatrix(resultMatrix);
        }
    }
}
