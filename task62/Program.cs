using System;

class Program
{
    static void Main()
    {
        int[,] spiralArray = GetSpiral(4, 4); // Создание спирального массива 4x4
        PrintArray(spiralArray); // Вывод спирального массива в консоль
    }

    static int[,] GetSpiral(int rows, int columns)
    {
        int[,] array = new int[rows, columns]; // Создание пустого массива нужной размерности
        int value = 1; // Начальное значение для заполнения массива
        int startRow = 0; // Начальный индекс строки
        int endRow = rows - 1; // Конечный индекс строки
        int startColumn = 0; // Начальный индекс столбца
        int endColumn = columns - 1; // Конечный индекс столбца

        while (startRow <= endRow && startColumn <= endColumn)
        {
            // Заполнение верхней строки слева направо
            for (int i = startColumn; i <= endColumn; i++)
            {
                array[startRow, i] = value++;
            }
            startRow++; // Переход на следующую строку

            // Заполнение правого столбца сверху вниз
            for (int i = startRow; i <= endRow; i++)
            {
                array[i, endColumn] = value++;
            }
            endColumn--; // Переход на предыдущий столбец

            if (startRow <= endRow)
            {
                // Заполнение нижней строки справа налево
                for (int i = endColumn; i >= startColumn; i--)
                {
                    array[endRow, i] = value++;
                }
                endRow--; // Переход на предыдущую строку
            }

            if (startColumn <= endColumn)
            {
                // Заполнение левого столбца снизу вверх
                for (int i = endRow; i >= startRow; i--)
                {
                    array[i, startColumn] = value++;
                }
                startColumn++; // Переход на следующий столбец
            }
        }

        return array; // Возврат заполненного спирального массива
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j].ToString("D2") + " "); // Вывод элемента массива с дополнением до 2 знаков
            }
            Console.WriteLine(); // Переход на новую строку после вывода каждой строки массива
        }
    }
}
