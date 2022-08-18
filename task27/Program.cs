/* Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

namespace task27
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0; // Инициализация переменных число и сумма(первоначально равна 0)
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0) // Пока число больше 0, выполняется следующие вычисления...
            {
                sum += (number % 10);  // Сумма = Сумма + (остаток от деления числа)
                number /= 10; // Число = Число деленное на 10
            }
            Console.WriteLine(sum);
        }
    }
}