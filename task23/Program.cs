/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
// Запрашиваем у пользователя ввод числа для построения таблицы кубов
Console.Write("Введите число: ");

// Считываем введенное число и сохраняем его в переменную "number"
int numberToCube = Convert.ToInt32(Console.ReadLine());

// Создаем строку для хранения таблицы кубов
string cubeTable = "";

// Итерируем от 1 до "numberToCube"
for (int i = 1; i <= numberToCube; i++)
{
    // Возводим "i" в куб и сохраняем результат в переменной "cubedNumber"
    int cubedNumber = (int)Math.Pow(i, 3);

    // Добавляем значение "cubedNumber" к строке "cubeTable"
    cubeTable += cubedNumber;

    // Если это не последнее число в таблице кубов, добавляем запятую и пробел
    if (i != numberToCube)
    {
        cubeTable += ", ";
    }
}

// Выводим таблицу кубов на консоль
Console.WriteLine(cubeTable);

