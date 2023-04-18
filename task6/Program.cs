/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите число: ");
int inputNumber = 0; // создание переменной для ввода числа
bool isInputValid = int.TryParse(Console.ReadLine(), out inputNumber); // проверка корректности ввода

if (isInputValid) // если ввод корректен
{
    if (inputNumber % 2 == 0) // если число четное
    {
        Console.Write("Да, число {0} четное", inputNumber);
    }
    else // если число нечетное
    {
        Console.Write("Нет, число {0} нечетное", inputNumber);
    }
}
else // если ввод некорректен
{
    Console.Write("Некорректный ввод");
}
