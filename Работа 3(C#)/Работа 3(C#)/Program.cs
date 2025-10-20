using System;
using System.Diagnostics.Metrics;
class Program
{
    ///<summary> Копирует все положительные элементы из исходного массива в новый массив.</summary>
    ///<param name="arr">Исходный одномерный целочисленный массив. </param>
    /// <returns>Новый массив, содержащий только положительные числа из исходного массива.
    /// Если положительных чисел нет, возвращается пустой массив (длиной 0).</returns>
    static int[] Arrays(int[] arr, string name)
    {
        Random rnd = new Random();
        Console.WriteLine($"Массив {name}:");
        for (int i = 0; i <= arr.Length-1; ++i)
        {
            arr[i] = rnd.Next(-100, 300);
            Console.Write($" {arr[i]}");
        }
        Console.WriteLine();
        int[] result = new int[arr.Length];
        return result;
    }
    static void Main()
    {
        string name;
        Console.Write("Введите название массива: ");
        name= Console.ReadLine();
        Console.Write("Введите размер массива: ");
        int countA = int.Parse(Console.ReadLine());
        int[] A = new int[countA];
        Arrays(A,name);

        Console.Write("Введите название массива: ");
        name = Console.ReadLine();
        Console.Write("Введите размер массива: ");
        int countB = int.Parse(Console.ReadLine());
        int[] B = new int[countB];
        Arrays(B, name);

        int[] C = new int[countA + countB];

        Console.WriteLine("Положительный массив С:");
        int count=0;
        for (int i = 0; i<=A.Length-1; ++i){ 
            if (A[i] > 0)
            {
                C[count]=A[i];
                count++;
            }
        }
        for (int j = 0; j <= B.Length-1; ++j)
        {
            if (B[j] > 0)
            {
                C[count] = B[j];
                count++;
            }
        }
        if (count == 0) {
            Console.WriteLine("Массив C пуст");
        }
        else
        {
            Console.Write("Массив С:");
            for (int i = 0; i < count; ++i)
            {
                Console.Write($" {C[i]}");
            }
            Array.Resize(ref C,count);
        }
    }
}


