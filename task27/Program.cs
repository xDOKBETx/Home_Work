/* Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

namespace MathUtils
{
    // Класс для вычисления суммы цифр
    class DigitSumCalculator
    {
        // Точка входа в приложение
        static void Main(string[] args)
        {
            // Пользовательский ввод
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            // Проверка на возможность преобразования в число
            if (!int.TryParse(input, out int inputNumber))
            {
                Console.WriteLine("Ошибка: введенная строка не является числом.");
                return;
            }

            // Вычисление суммы цифр
            int digitSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                // Проверка на отрицательное число
                if (c == '-' && i == 0)
                {
                    continue; // Пропустить символ '-' в начале числа
                }

                // Проверка на цифру
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Ошибка: введенная строка не является числом.");
                    return;
                }

                // Вычисление суммы цифр
                digitSum += c - '0'; // Конвертирование символа в числовое значение и добавление его к сумме цифр
            }

            // Вывод результата
            Console.WriteLine($"Сумма цифр в числе {inputNumber} равна {digitSum}.");
        }
    }
}
