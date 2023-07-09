using System;
using System.Numerics;

class Cw5
{
    static void Main()
    {
        //pojecia nie mam o co chodzi ani jak to zrobic
        //licznik = x^i
        //mianownik = i!
        //ulamek = licznik / mianownik
        //???
        double x = 2;
        int n = 3;
        double i = 0;
        double licznik = Math.Pow(x, i);
        double silnia = 1;
        for (int j = 1; j <= n; j++)
        {
            silnia *= j;
        }
        double mianownik = silnia;
        double ulamek = licznik / mianownik;
        //... ???

    }
}