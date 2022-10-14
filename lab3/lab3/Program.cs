

using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите любое число{i}/2");
                a[i] = int.Parse(Console.ReadLine());
            }

            if (a[0] != a[1] && a[1] != a[2] && a[2] != a[0])
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
  