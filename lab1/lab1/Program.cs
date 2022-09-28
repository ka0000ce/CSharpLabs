namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double I;
            double U;
            bool isOK = false;
            do
            {
                Console.WriteLine("Введiть напругу:");
                string strU = Console.ReadLine();
                isOK = double.TryParse(strU, out U);
                if (!isOK)
                {
                    Console.WriteLine("Дурко , не правельно!");
                }
            }
            while (!isOK);
            Console.WriteLine("Введiть опiр:");
            double strR = double.Parse(Console.ReadLine());
            if (strR <= 0)
            {
                Console.WriteLine("І знову не вірно.");
                Console.ReadLine();
                return;
            }
            I = U / strR;
            Console.WriteLine($"Отримуємо : {I}");
            Console.ReadKey();
        }
    }
}