

namespace _7._Max_Sequence_of_Equal_Elements
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
            int maxNumber = int.MinValue;
            int index = 0;
            string leftmost = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)//2 1 1 2 3 3 2 2 2 2 1
            {                                                   //i
                
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (counter > maxNumber)
                    {
                        maxNumber = counter;
                        index = i;
                    }
                }
                else
                {
                    counter = 0;
                } 
            }

            for (int x = 1; x <= maxNumber + 1; x++)
            {
                Console.Write($"{arr[index]} ");
            }
        }
    }
}
