using System;
class Cw4
{
    static void Main()
    {
        Console.WriteLine("podaj kwote");
        int kwotaPoczatkowa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("podaj procent");
        double oprocentowanie = Convert.ToDouble(Console.ReadLine()) / 100;
        Console.WriteLine("podaj liczbe miesiecy");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());
        double procentNaMiesiac = oprocentowanie / liczbaMiesiecy;
        
        double zarobek = kwotaPoczatkowa * procentNaMiesiac * liczbaMiesiecy;
        Console.WriteLine(zarobek);
    
    }
}