// Задача 37: Найдите произведение пар чисел в 
// одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Введите размер  массива:");
	int size = Convert.ToInt32(Console.ReadLine());
	
	int[] array = GetArray(size, 1, 5);
	
	Console.WriteLine($"Массив: [{String.Join(";", array)}]");
	
	int[] GetArray(int size, int minValue, int maxValue)
	{
	    int[] result = new int[size];
	    for (int i = 0; i < result.Length; i++)
	    {
	        result[i] = new Random().Next(minValue, maxValue + 1);
	    }
	    return result;
	}
	int resMultip = size/2+size%2;
	int[] result = new int[resMultip]; 
	for (int i = 0; i < resMultip; i++)
	
	{
	   
	    if (i!=size - 1 - i) result[i] = array[i] * array[size - 1 - i];
		else result[i] = array[i];
	
	}
	Console.WriteLine($"Массив: [{String.Join(";", result)}]");