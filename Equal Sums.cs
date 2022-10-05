

namespace _6._Equal_Sums
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
            int leftSum = 0;
            int rightSum = 0;
            bool isEqual = false;
            for (int i = 0; i < arr.Length; i++)//1 2 3 3
            {
                for (int x = 0; x < arr.Length - 1 - i; x++)
                {
                    rightSum += arr[x +i + 1];
                }
                for (int x = i; x > 0; x--)
                {
                    leftSum += arr[x - 1];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    return;
                }
                rightSum = 0;
                leftSum = 0;
            }
            if (isEqual)
            {

            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
