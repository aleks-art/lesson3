// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
using System;
using System.IO;
Random rnd = new Random();
Console.Write("Введите размер массива ");
int Count = Convert.ToInt32(Console.Read());
double[] array = new double[Count];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.NextDouble()*Count;
}
double min=array[0];
double max=array[0];
int a = 1;
while (a<array.Length)
{
if (min>array[a])
{
min=array[a];
}
if(max<array[a])
{
    max=array[a];
}
a++;
}
double ras = max-min;
Console.WriteLine("Разница между максимальным и минимальным элементов массива, " + ras);