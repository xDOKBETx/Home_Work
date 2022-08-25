/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве. 
 [345, 897, 568, 234] -> 2
*/

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size;i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if(i == 0) Console.Write("[");
		if(i < array.Length - 1) Console.Write(array[i] + ",");
		else Console.Write(array[i] + "]");
	}
}


void EvenElements (int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] % 2 == 0){
			sum++;
		}
	}
	Console.WriteLine($"Количество четных чисел = {sum} ");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size,100,999);
PrintArray(array); 
Console.WriteLine(); 
EvenElements(array); 