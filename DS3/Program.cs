// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = CreateArray(5,0,20);

PrintArray(array);

int min, max;
min = array[0];
max=array[0];

for (int i = 0; i < array.Length; i++)
{
if (array[i]>max)
max=array[i];
if (array[i]<min)
min=array[i];
}

Console.Write($"{max-min}");

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