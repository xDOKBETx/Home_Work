/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

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
