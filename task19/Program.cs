﻿/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да
*/

// Запрос у пользователя ввести пятизначное число
Console.Write("Введите пятизначное число: ");

int number;
// Проверяем, является ли введенное значение числом и является ли оно пятизначным
if (!int.TryParse(Console.ReadLine(), out number) || number < 10000 || number > 99999)
{
Console.WriteLine("Некорректное значение! Введите пятизначное число.");
return;
}

int reversedNumber = 0; // переменная для хранения перевернутого числа
int tempNumber = number; // временная переменная для хранения исходного числа

// Переворачиваем исходное число
while (tempNumber > 0)
{
reversedNumber = reversedNumber * 10 + tempNumber % 10; // На каждой итерации добавляем последнюю цифру исходного числа в конец перевернутого числа
tempNumber /= 10; // Убираем последнюю цифру из исходного числа
}

// Сравниваем исходное число с перевернутым
if (number == reversedNumber)
{
Console.WriteLine("Да, это палиндром"); // Если числа равны, то это палиндром
}
else
{
Console.WriteLine("Нет, это не палиндром"); // Если числа не равны, то это не палиндром
}
