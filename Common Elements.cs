

namespace _2._Common_Elements
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string[] secondArr = Console.ReadLine()
                .Split(" ")
                .ToArray();
            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int x = 0; x < firstArr.Length; x++)
                {
                    if (secondArr[i] == firstArr[x])
                    {
                        Console.Write($"{secondArr[i]} ");
                    }
                }
            }
        }
    }
}
