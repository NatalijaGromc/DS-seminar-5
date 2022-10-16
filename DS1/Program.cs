// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateArray(10, 100, 999);

PrintArray(array);

int count = 0;

foreach (int item in array)
{
if (item % 2 == 0)
count++;
}

Console.Write($"{count}");

int[] CreateArray(int size, int min = 0, int max = 10)
{
int[] _array = new int[size];
for (int i = 0; i < size; i++)
_array[i] = new Random().Next(min, max);
return _array;
}

void PrintArray(int[] _array)
{
Console.Write("[");
foreach (var item in _array)
Console.Write($"{item} ");
Console.Write("]");
Console.WriteLine();
}