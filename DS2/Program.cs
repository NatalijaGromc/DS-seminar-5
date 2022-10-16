//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArray(new Random().Next(4, 11));

int lengthA = 0;
if (array.Length % 2 != 0)
lengthA = array.Length / 2 + 1;
else
lengthA = array.Length / 2;

int[] newArray = new int[lengthA];

PrintArray(array);

for (int i = 0, z = array.Length - 1; i < array.Length; i++, z--)
{

if (z < i)
break;
else if (z == i)
{
newArray[i] = array[i];
break;
}
newArray[i] = array[i] * array[z];
}

PrintArray(newArray);

// Методы массивов
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