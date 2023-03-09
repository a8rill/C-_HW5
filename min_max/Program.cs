// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Используйте NextDouble().



Console.WriteLine("Введите количество элементов массива:");
int size=int.Parse(Console.ReadLine());
double[] array = new double[size];
for(int i=0;i<size;i++)
{
array[i]= new Random().NextDouble();
}

Console.WriteLine("Вывод элементов массива");
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

double max=array[0];
double min=array[0];

for(int i=0;i<size;i++)
{
if (max<array[i]) max=array[i];
if (min>array[i]) min=array[i];
}
double result=max-min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result:0.###}");

