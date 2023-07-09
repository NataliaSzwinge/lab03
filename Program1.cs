using System;
public class MyProgram
{
    public static void Main()
    {
        int x, y, wynik = 1;
        Console.WriteLine("podaj x");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("podaj y");
        y = Convert.ToInt32(Console.ReadLine());

        while (y > 0)
        {
            wynik *= x;
            y--;
        }

        Console.WriteLine(wynik);
    }
}