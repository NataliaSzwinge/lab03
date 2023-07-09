using System;
public class MyProgram
{
    public static void Main()
    {
        int f1 = 1;
        int f2 = 1;
        Console.WriteLine("podaj nr wyrazu ciagu");
        int n = Convert.ToInt32(Console.ReadLine());
        int fn;
        if (n < 3)
        {
            Console.WriteLine(n + " wyraz ciągu to 1");
        }
        else
        {
            for (int i = 3; i <= n; i++)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
            }
            Console.WriteLine(n + " wyraz ciagu to " + f2);
        }
    }
}