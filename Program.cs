// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];
int count = 0;
int[] GetArray(int[]array)
{for (int i=0; i < array.Length; i++)
{array[i] = new Random().Next(99,1000);
if (array[i] % 2 ==0)
{count++;
}
}
return array;
}
GetArray(array);
Console.WriteLine(String.Join("", array));
Console.WriteLine("Кол-во четных чисел в массиве"  +count);
