using System;
using static System.Math;

namespace ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] v = new int[9];
        SetData(ref v);
        Task1(v);
        int[] x = Task2(v);
        Task3(v, x);
    }

    private static void SetData(ref int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write("Введите значение: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    private static void Task1(in int[] array)
    {
        int minValue = array[0];
        int minValueIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minValueIndex = i;
            }
        }

        Console.WriteLine($"Минимальный элемент: {minValue}, его индекс: {minValueIndex + 1}");
    }

    private static int[] Task2(in int[] array)
    {
        int[] outArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++) outArray[i] = -4 * array[i];
        GetInfo(outArray);
        return outArray;
    }

    private static void Task3(in int[] arrayV, in int[] arrayX)
    {
        int count = 0;

        for (int i = 0; i < arrayV.Length && i < arrayX.Length; i++)
        {
            if (Abs(arrayX[i]) > arrayV[i])
            {
                Console.WriteLine(arrayX[i]);
                count++;
            }
        }

        Console.WriteLine($"Количество элементов: {count}");
    }

    private static void GetInfo(in int[] array)
    {
        for (int i = 0; i < array.Length; i++) Console.WriteLine($"Элемент {i + 1}: {array[i]}");
    }
}