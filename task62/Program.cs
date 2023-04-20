using System;

internal class NewBaseType
{
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program : NewBaseType
{
    static void Main()
    {
        int[,] myArray = GetSpiral(4, 4);
        PrintArray(myArray);
    }

    static int[,] GetSpiral(int rows, int columns)
    {
        int[,] array = new int[rows, columns];
        int value = 1;
        int startRow = 0;
        int endRow = rows - 1;
        int startColumn = 0;
        int endColumn = columns - 1;

        while (startRow <= endRow && startColumn <= endColumn)
        {
            // Fill the top row
            for (int i = startColumn; i <= endColumn; i++)
            {
                array[startRow, i] = value++;
            }
            startRow++;

            // Fill the right column
            for (int i = startRow; i <= endRow; i++)
            {
                array[i, endColumn] = value++;
            }
            endColumn--;

            if (startRow <= endRow)
            {
                // Fill the bottom row
                for (int i = endColumn; i >= startColumn; i--)
                {
                    array[endRow, i] = value++;
                }
                endRow--;
            }

            if (startColumn <= endColumn)
            {
                // Fill the left column
                for (int i = endRow; i >= startRow; i--)
                {
                    array[i, startColumn] = value++;
                }
                startColumn++;
            }
        }

        return array;
    }
}
