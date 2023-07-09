using System;
public class MyProgram
{
    public static void Main()
    {

        int n, k;
        int silniaN = 1;
        int silniaK = 1;
        n = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToInt32(Console.ReadLine());
        if (n < 5 || k < 5)
        {
            Console.WriteLine("Podaj liczbe wieksza od 5");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                silniaN *= i;
            }
            for (int i = 1; i < k; i++)
            {
                silniaK *= k;
            }
            int licznik = silniaN - silniaK;
            int mianownik = silniaK;
            int m = licznik / mianownik;
            Console.WriteLine(m);
        }
    }
}