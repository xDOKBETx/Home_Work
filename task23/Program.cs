﻿/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++) // Пока выполняется условие где "i" меньше или равно "number", будет высчитываться куб числа "i". После чего значение "i" увеливается на + 1 и цикл повторяется
{
    Console.Write(Math.Pow(i, 3) + ", "); // Возведение числа "i" в куб и вывод результатов

}
