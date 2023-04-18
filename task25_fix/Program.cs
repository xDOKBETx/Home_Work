/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать функцию возведения в степень самостоятельно!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

namespace Exponentiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите основание: ");
            int baseNum = Convert.ToInt32(Console.ReadLine()); // Чтение основания

            Console.Write("Введите степень: ");
            int powNum = Convert.ToInt32(Console.ReadLine()); // Чтение показателя степени

            // Вывод результата на консоль с помощью интерполяции строк и вызова функции Exponentiation
            Console.WriteLine($"{baseNum}, {powNum} -> {Exponentiation(baseNum, powNum)}");
        }

        // Функция Exponentiation вычисляет степень числа baseNum в степени powNum
        static int Exponentiation(int baseNum, int powNum)
        {
            int expNum = baseNum; // Присваиваем начальное значение expNum равное baseNum

            for (int i = 1; i < powNum; i++)
            {
                expNum *= baseNum; // Вычисление степени
            }

            return expNum; // Возвращаем результат вычисления степени
        }
    }
}
