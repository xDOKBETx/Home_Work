/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/


// Метод для генерации трехмерного массива из неповторяющихся двузначных чисел
int[,,] GetArray()
{
    // Создаем массив для хранения неповторяющихся двузначных чисел
    int[] uniqueTwoDigitNums = new int[8];

    // Создаем генератор случайных чисел
    Random random = new Random();

    // Заполняем массив неповторяющимися двузначными числами
    for (int i = 0; i < uniqueTwoDigitNums.Length; i++)
    {
        int num;
        bool isUnique = false;

        // Генерируем уникальное число, пока не найдем неповторяющееся
        while (!isUnique)
        {
            num = random.Next(10, 100);
            isUnique = !uniqueTwoDigitNums.Contains(num);
            if (isUnique)
            {
                uniqueTwoDigitNums[i] = num;
            }
        }
    }

    // Создаем трехмерный массив
    int[,,] threeDimensionalArray = new int[2, 2, 2];

    // Переменная для отслеживания текущей позиции в массиве uniqueTwoDigitNums
    int temp = 0;

    // Заполняем трехмерный массив числами из массива uniqueTwoDigitNums
    for (int i = 0; i < threeDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDimensionalArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDimensionalArray.GetLength(2); k++)
            {
                threeDimensionalArray[i, j, k] = uniqueTwoDigitNums[temp++];
            }
        }
    }

    // Возвращаем трехмерный массив с неповторяющимися двузначными числами
    return threeDimensionalArray;
}

// Метод для вывода трехмерного массива с индексами каждого элемента
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                // Выводим элемент массива и его индексы
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

// Создаем трехмерный массив с неповторяющимися двузначными числами и выводим его на экран
PrintArray(GetArray());
