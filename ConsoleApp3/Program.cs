using System;
using static System.Math;

namespace ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] v = new int[17];

        for (var i = 0; i < v.Length; i++)
        {
            Console.Write("Введите значение: ");
            v[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < v.Length; i++) Console.WriteLine($"Элемент {i + 1}: {v[i]}");
        //Нахождение минимального элемента и его номер
        int minValue = v[0];
        int minValueIndex = 0;

        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] < minValue)
            {
                minValue = v[i];
                minValueIndex = i;
            }
        }

        Console.WriteLine($"Минимальный элемент: {minValue}, его индекс: {minValueIndex + 1}");

        int[] x = new int[v.Length];
        for (int i = 0; i < v.Length; i++) x[i] = -4 * v[i];

        //Вывод массива x
        for (int i = 0; i < x.Length; i++) Console.WriteLine($"Элемент {i + 1}: {x[i]}");


        //Подсчёт произведения и кол-ва элементов
        int count = 0;
        long product = 1;
        for (int i = 0; i < v.Length && i < x.Length; i++)
        {
            if (Abs(x[i]) > v[i])
            {
                product *= x[i];
                count++;
            }
        }

        Console.WriteLine($"Произведение:{product}\nКоличество элементов: {count}");
    }
}