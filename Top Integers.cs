

namespace _5._Top_Integers
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
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)//1, 4, 3, 2
            {
                for (int x = 1; x <= arr.Length - 1 - i; x++)//1->3, 4->2, 3->1, 2->1
                {
                    if (arr[i] > arr[i + x])//1->4, 1->3, 1->2
                    {
                        counter++;
                        if (counter == arr.Length - 1 - i)
                        {
                            Console.Write($"{arr[i]} ");
                        }
                    }
                }
                counter = 0;
            }
            Console.Write(arr[arr.Length - 1]);
        }
    }
}
