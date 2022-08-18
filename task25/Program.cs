/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать функцию возведения в степень самостоятельно!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

namespace task25  // Название проекта
{
    class Program // Объявление класса 
    {
        static void Main(string[] args) /* # Заголовок метода где static – это модификатор
Void – тип возвращаемого значения. Ключевое слово, которое указывает на то, что метод ничего не возвращает посредством return
Main – имя «функции»
String [] args – параметр method. Представляет собой массив строк */
        {
            int baseNum, powNum, result = 1; // Инициализация переменных
            Console.Write("Введите число: ");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            powNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= powNum; i++) // Инициализация счётчика цикла "i"; условие цикла; увеличение счётчика
            {
                result = result * baseNum; // Вычисления
            }
            Console.WriteLine(result);


        }
    }
}