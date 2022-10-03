// Все массивы от 5-ти элементов
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = GetArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(", ", array)}]"!);
// int even = EvenNum(array);
// Console.WriteLine($"Количесто четных элементов в заданном массиве = {even}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = GetArray(10, 10, 20);
Console.WriteLine($"[{String.Join(", ", array)}]"!);
int result = NoEvenNumSum(array);
Console.WriteLine($"Сумма всех элементов стоящих на нечетных позициях в заданном массиве = {result}"!);


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenNum(int[] array)
{
  int a = 0;
  for (int i = 0; i < array.Length; i++)
  if (array[i] % 2 == 0)
    {
      a++;
    }
    return a;
}

int NoEvenNumSum(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  if (i % 2 != 0)
    {
      sum += array[i];
    }
    return sum;
}