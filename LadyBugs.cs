

namespace _10._LadyBugs
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());//3
            int[] initialIndexes = Console.ReadLine()//0  1
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ladyBugArray = new int[fieldSize];//1 1 0

            //if (fieldSize >= initialIndexes.Length)
            //{
            for (int i = 0; i < Math.Min(initialIndexes.Length, fieldSize); i++)
            {
                if (ladyBugArray[initialIndexes[i]] >= 0 && ladyBugArray[initialIndexes[i]] < ladyBugArray.Length)
                {
                    ladyBugArray[initialIndexes[i]] = 1;
                }
            }
            //}
            //else
            //{
            //    for (int i = 0; i < fieldSize; i++)
            //    {
            //        ladyBugArray[initialIndexes[i]] = 1;
            //    }
            //}

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandToArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(commandToArray[0]);
                int flyLength = int.Parse(commandToArray[2]);
                string direction = commandToArray[1];

                if (ladybugIndex < 0 || ladybugIndex >= ladyBugArray.Length)
                {
                    continue;
                }

                if(ladyBugArray[ladybugIndex] == 0)
                {
                    continue;
                }

                if (direction == "right" && ladyBugArray[ladybugIndex] == 1 && ladybugIndex < ladyBugArray.Length)
                {
                    for (int i = ladybugIndex; i < ladyBugArray.Length; i++)//0-1
                    {
                        if ((i + flyLength) >= 0 && (i + flyLength) < ladyBugArray.Length)
                        {
                            if (ladyBugArray[i + flyLength] != 1)
                            {
                                ladyBugArray[i + flyLength] = 1;
                                ladyBugArray[ladybugIndex] = 0;
                                break;
                            }
                        }
                        else
                        {
                            ladyBugArray[ladybugIndex] = 0;
                            break;
                        }
                    }
                }
                else if (direction == "left" && ladyBugArray[ladybugIndex] == 1 && ladybugIndex < ladyBugArray.Length)
                {
                    if (flyLength < 0)
                    {
                        for (int i = ladybugIndex; i < ladyBugArray.Length; i++)
                        {
                            if ((i - flyLength) >= 0 && (i - flyLength) < ladyBugArray.Length)
                            {
                                if (ladyBugArray[i - flyLength] != 1)
                                {
                                    ladyBugArray[i - flyLength] = 1;
                                    ladyBugArray[ladybugIndex] = 0;
                                    break;
                                }
                            }
                            else
                            {
                                ladyBugArray[ladybugIndex] = 0;
                                break;
                            }
                        }
                    }
                    else if (flyLength >= 0)
                    {
                        //for (int i = ladybugIndex; i > 0; i--)
                        //{
                        //    if ((i - flyLength) >= 0 && (i - flyLength) < ladyBugArray.Length)
                        //    {
                        //        if (ladyBugArray[i - flyLength] != 1)
                        //        {
                        //            ladyBugArray[i - flyLength] = 1;
                        //            ladyBugArray[ladybugIndex] = 0;
                        //            break;
                        //        }
                        //    }
                        //    else
                        //    {
                        //        ladyBugArray[ladybugIndex] = 0;
                        //        break;
                        //    }
                        //}
                        while ((ladybugIndex - flyLength) >= 0 && (ladybugIndex - flyLength) < ladyBugArray.Length 
                            && (ladyBugArray[ladybugIndex - flyLength] != 1))
                        {
                            ladyBugArray[ladybugIndex - flyLength] = 1;
                            ladyBugArray[ladybugIndex] = 0;
                        }
                        if((ladybugIndex - flyLength) < 0 || (ladybugIndex - flyLength) >= ladyBugArray.Length)
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', ladyBugArray));
        }
    }
}
