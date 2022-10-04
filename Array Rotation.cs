
namespace _4._Array_Rotation
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

            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int first = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = first;
                }
                n--;
            }
            Console.WriteLine(string.Join(' ', arr)); 
        }
    }
}
