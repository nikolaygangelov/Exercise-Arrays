

namespace _8._Magic_Sum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int x = 0; x < arr.Length - 1 - i; x++)
                {
                    if (arr[i] + arr[i + x + 1] == magicNumber)
                    {
                        Console.WriteLine($"{arr[i]} {arr[i + x + 1]}");
                    }
                }
            }
        }
    }
}
