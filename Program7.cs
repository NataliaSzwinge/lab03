using System;
namespace cw7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pary liczb naturalnych o sumie " + n);
            for(int i = 1; i <= n / 2; i++)
            {
                int j = n - i;
                Console.WriteLine(i + " " + j);
            }
        }
    }
}