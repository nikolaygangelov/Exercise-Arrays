

namespace _3._Zig_Zag_Arrays
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] inputArray = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 != 0)
                {
                    firstArray[i] = inputArray[0];
                    secondArray[i] = inputArray[1];
                }
                else
                {
                    firstArray[i] = inputArray[1];
                    secondArray[i] = inputArray[0];
                }
            }
            Console.WriteLine(string.Join(' ', secondArray));
            Console.WriteLine(string.Join(' ', firstArray));
        }
    }
}
