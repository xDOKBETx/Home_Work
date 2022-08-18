/* Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19] 
3, 1, 35 -> [6, 1, 33]
Первое число - количество элементов 
Второе число - «а» начало диапазона случайных чисел (включительно) 
Третье число - «b» конец диапазона (не включительно)
*/

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, min, max;

            Console.Write("Введите размер массива: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минимальный эллемент массива: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальный эллемент массива: ");
            max = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)

            {
                array[i] = new Random().Next(min, max + 1);
            }
            Console.WriteLine($"[{String.Join(",", array)}]");
        }
    }
}