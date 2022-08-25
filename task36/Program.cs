/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

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

int SumOfOddElements(int[] array){

	int sum = 0;

	for (int i = 1; i < array.Length; i++)
	{
		if (i % 2 != 0){
			sum += array[i];
		}
	}
	return sum;
}

int[] array = GetArray(size,-100,100);
PrintArray(array); 
Console.WriteLine(); 

int sum = SumOfOddElements(array);

Console.WriteLine($"Сумма нечетных элементов = {sum}");
