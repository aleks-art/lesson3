// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
using System;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число от 1 до 100 000 ");
        int count = Convert.ToInt32(Console.ReadLine());
        int count1 = count;
        int del = 1;
        int leng = 1;
        while (count1>=10)
        {
            count1 = count1 / 10;
            del *= 10;
            leng++;
        }
               int[] array = new int [leng];
        for (int i = 0; i < leng; i++)
        {
           array[i]= count/del;
           count %= del;
           del /= 10;
           Console.Write(array[i]+" ");
        }
        
    }
}