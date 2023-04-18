/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
var firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
var secondNumber = Convert.ToInt32(Console.ReadLine());

// Находим максимальное число
if (firstNumber > secondNumber)
{
    Console.Write($"Максимальное число: {firstNumber}");
}
else
{
    Console.Write($"Максимальное число: {secondNumber}");
}
