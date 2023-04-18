﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
// Запрашиваем у пользователя трёхзначное число
Console.Write("Введите трёхзначное число от 100 до 999: ");
int userInput = Convert.ToInt32(Console.ReadLine());

// Извлекаем вторую цифру из числа, используя операторы деления и остатка от деления
int secondDigit = userInput / 10 % 10;

// Выводим вторую цифру на экран, используя строку формата
Console.Write($"Вторая цифра числа {userInput}: {secondDigit}");
