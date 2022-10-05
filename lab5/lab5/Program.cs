using System;
using System.Linq;
namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Введiть кiлькiсть рядкiв: ");
            m = Convert.ToInt32(Console.ReadLine());
            
           
            Console.WriteLine("Введiть кiлькiсть стовпчикiв: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            
            int[,] arr = new int[m, n];
            var random = new Random();
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = random.Next(0, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();    
            for (int i = 0; i < m; i++)
            {
                int min = arr[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
                Console.WriteLine("Рядок {0} : мiнiмальне значення {1}", i, min);
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] > max)
                    {
                        max = arr[j, i];
                    }
                }
                Console.WriteLine("Стовпчик {0} : максимальне значення {1}", i, max);
            }
            Console.WriteLine();
        }
    }
}