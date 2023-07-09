using System;
namespace cw8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pomyśl liczbę z zakresu od 1 do 20.");
            Console.WriteLine("Odpowiedz ujemną, jeśli liczba jest mniejsza,");
            Console.WriteLine("dodatnią, jeśli liczba jest większa,");
            Console.WriteLine("lub wpisz 0, jeśli zgadłem liczbę.");

            int dolnyPrzedzial = 1;
            int gornyPrzedzial = 20;
            int propozycja;

            do
            {
                propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;
                Console.WriteLine("Czy liczba, o której myślisz, to {0}?", propozycja);
                int odpowiedz = Convert.ToInt32(Console.ReadLine());

                if (odpowiedz < 0)
                {
                    gornyPrzedzial = propozycja - 1;
                }
                else if (odpowiedz > 0)
                {
                    dolnyPrzedzial = propozycja + 1;
                }
                else
                {
                    Console.WriteLine("Zgadłem! Liczba, o której myślisz, to {0}.", propozycja);
                }
            } while (propozycja != 0);
        }
    }
}