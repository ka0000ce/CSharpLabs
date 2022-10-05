using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.Write("Введіть довжину масиву: ");

            int[] arr = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введіть " + i + " елемент масиву = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        c++;
                    }
                }

                if (b < c)
                {
                    b = c;
                    a = arr[i];
                }
                c = 0;

                Console.WriteLine("Найбільше повторень = {0}, кількість повторень = {1}", a, b);
            }


            Console.ReadKey(true);
        }
    }
}