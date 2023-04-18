/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

<<<<<<< HEAD
// Запросить у пользователя количество чисел, которое он хочет ввести
Console.Write("Введите количество чисел: ");
int numberOfInputs;
// Проверить, что введенное значение является целым числом больше нуля
while (!int.TryParse(Console.ReadLine(), out numberOfInputs) || numberOfInputs <= 0)
{
    // Если значение некорректно, запросить повторный ввод
    Console.WriteLine("Некорректный ввод. Введите положительное целое число: ");
}

// Создать массив, в который будут сохранены введенные пользователем числа
int[] numbersArray = new int[numberOfInputs];

// Функция для ввода чисел пользователем
void InputNumbers(int numberOfInputs)
{
    // Перебирать элементы массива и запрашивать у пользователя значения
    for (int i = 0; i < numberOfInputs; i++)
    {
        // Запросить у пользователя очередное число
        Console.Write($"Введите {i + 1}-е число: ");
        // Проверить, что введенное значение является целым числом
        while (!int.TryParse(Console.ReadLine(), out numbersArray[i]))
        {
            // Если значение некорректно, запросить повторный ввод
            Console.WriteLine("Некорректный ввод. Введите целое число: ");
        }
    }
}

// Функция для подсчета количества положительных чисел в массиве
int CountPositiveNumbers(int[] numbersArray)
{
    int count = 0;
    // Перебирать элементы массива и подсчитывать количество положительных чисел
=======
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
>>>>>>> 42cf586ff41c6457aefa25349b01b0d319b847ed
    for (int i = 0; i < numbersArray.Length; i++)
    {
        if (numbersArray[i] > 0) count++;
    }
    return count;
}

<<<<<<< HEAD
// Вызвать функцию для ввода чисел пользователем
InputNumbers(numberOfInputs);
// Вывести количество положительных чисел
Console.WriteLine($"Количество положительных чисел: {CountPositiveNumbers(numbersArray)}");
=======
CurrentNumbers(m);
Console.WriteLine($"Чисел больше 0: {PositivNumbers(numbersArray)}");
>>>>>>> 42cf586ff41c6457aefa25349b01b0d319b847ed
