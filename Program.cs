// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
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
            array[i] = rnd.Next(0, 1010);

            if (array[i]%2==0)
            {
                count++;
            }
        }
        Console.WriteLine("Количество чётных элементов массива, " + count);
    }
}