//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArray(new Random().Next(4, 11));

PrintArray(array);

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
if (i%2 != 0)
sum += array[i];
}

Console.Write($"{sum}");

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