/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Просим пользователя ввести координаты двух точек
Console.Write("Введите координату x1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

// Вычисляем расстояние между двумя точками в 3D пространстве с использованием формулы
double distance = Math.Sqrt(Math.Pow(x2Coordinate - x1Coordinate, 2) + Math.Pow(y2Coordinate - y1Coordinate, 2) + Math.Pow(z2Coordinate - z1Coordinate, 2));

// Выводим ответ с округлением до двух знаков после запятой
Console.WriteLine($"Расстояние между двумя точками: {distance:f2}");
