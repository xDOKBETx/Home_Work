/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Write($"Введите число М (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbersArray = new int[m];

void CurrentNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        numbersArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int PositivNumbers(int[] numbersArray)
{
    int count = 0;
    for (int i = 0; i < numbersArray.Length; i++)
    {
        if (numbersArray[i] > 0) count++;
    }
    return count;
}

CurrentNumbers(m);
Console.WriteLine($"Чисел больше 0: {PositivNumbers(numbersArray)}");
