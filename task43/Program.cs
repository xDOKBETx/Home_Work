/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

<<<<<<< HEAD
using System;

class Program
{
    static void Main(string[] args)
    {
        double k1, b1, k2, b2;

        // Запросите у пользователя значения k1, b1, k2 и b2 и сохраните их в соответствующих переменных.
        Console.WriteLine("Введите значение k1:");
        k1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение b1:");
        b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение k2:");
        k2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение b2:");
        b2 = double.Parse(Console.ReadLine());

        // Если k1 и k2 равны, то прямые параллельны, и нет точки пересечения. В этом случае мы выводим соответствующее сообщение.
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны, нет точки пересечения.");
        }
        else
        {
            // Иначе, мы находим координаты точки пересечения, используя формулы x = (b2 - b1) / (k1 - k2) и y = k1 * x + b1.
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            // Выводим на экран координаты найденной точки пересечения.
            Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y);
        }

        // Ожидаем, пока пользователь не нажмет клавишу Enter, чтобы консольное окно не закрывалось сразу же после вывода результата.
        Console.ReadLine();
    }
}
=======
double IntersectionX(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k1 - k2);
    return (-x);
}
double IntersectionY(double k1, double x, double b1)
{
    double y = k1 * x + b1;
    return (y);
}
Console.Write("Введите значение к1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение к2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты точки пересечения = ({IntersectionX(k1, b1, k2, b2)};{IntersectionY(k1, IntersectionX(k1, b1, k2, b2), b1)})");
>>>>>>> 42cf586ff41c6457aefa25349b01b0d319b847ed
