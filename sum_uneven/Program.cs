﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] array = GetArray(10, -10, 10);
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



int size = array.Length;
int sumUneven = 0; 
for (int i = 1; i < size; i+=2)
{
Console.WriteLine($"array [{i}]={array[i]}"); 
sumUneven += array[i];
}
Console.WriteLine($"Сумма элеменотов стощих на  нечетных позициях:{sumUneven}");