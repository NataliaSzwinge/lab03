using System;
namespace cw6
{

    class Program
    {
        static int Silnia(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Silnia(n - 1);
        }

        static void Main()
        {
            Console.WriteLine("Podaj liczbę x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int n = 0;
            while (Silnia(n) < x)
            {
                n++;
            }

            if (Silnia(n) == x)
            {
                Console.WriteLine("Liczba " + x + " jest silnią liczby " + n);
            }
            else
            {
                Console.WriteLine("Liczba " + x + " nie jest silnią żadnej liczby.");
            }
        }
    }
}