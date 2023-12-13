//Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
using System;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int count = 0;
        int[] array = new int [9];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 101);

            if (array[i] > 20 && array[i] < 90)
            {
                count++;
            }
        }
        Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90] " + count);
    }
}