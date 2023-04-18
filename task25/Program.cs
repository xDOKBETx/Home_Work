/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать функцию возведения в степень самостоятельно!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

namespace Exponentiation // Объявление пространства имён
{
    class Program // Объявление класса 
    {
        static void Main(string[] args) // Метод Main - входная точка программы
        {
            int baseNum, exponent, result = 1; // Инициализация переменных: основание, показатель степени, результат

            Console.Write("Введите число: ");
            baseNum = Convert.ToInt32(Console.ReadLine()); // Чтение основания с консоли

            Console.Write("Введите степень: ");
            exponent = Convert.ToInt32(Console.ReadLine()); // Чтение показателя степени с консоли

            for (int i = 1; i <= exponent; i++) // Цикл для вычисления степени числа
            {
                result *= baseNum; // Вычисление степени
            }

            Console.WriteLine($"Результат: {result}"); // Вывод результата на консоль
        }
    }
}
