// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = GetArray(4, 100, 999);
Console.WriteLine($"Массив: [{String.Join(";", array)}]");
Console.WriteLine($"Количество чётных чисел:{GetEven( array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
int[] result = new int[size]; 
for (int i = 0; i < result.Length; i++) 
{
result[i] = new Random().Next(minValue, maxValue + 1);
}
return result; 
}

int GetEven( int [] number )
{ int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 == 0)
    count++;
    }
  return count; 
}