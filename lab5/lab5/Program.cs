using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
            {
                {2, 3, 4, 5, 6 },
                {6, 7, 8, 9, 10 },
                {11, 12, 7, 14, 15 },
                {16, 17, 18, 19, 20 }
            };

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);
            Console.WriteLine("First array: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < height; i++)
            {
                int maxIndex = 0;
                int minIndex = 0;

                for (int j = 0; j < width; j++)
                {
                    int max = myArray[i, 0];
                    int min = myArray[i, 0];
                    if (myArray[i, j] > max)
                    {
                        max = myArray[i, j];
                        maxIndex = j;

                    }
                    if (myArray[i, j] < min)
                    {
                        min = myArray[i, j];
                        minIndex = j;
                    }
                }
                int bob = myArray[i, maxIndex];
                myArray[i, maxIndex] = myArray[i, minIndex];
                myArray[i, minIndex] = bob;
            }
            Console.WriteLine("Final array: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}