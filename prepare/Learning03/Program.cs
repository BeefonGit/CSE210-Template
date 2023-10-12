using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        fraction.Fraction_c();
        Console.WriteLine(fraction.GetFractionString());
        int top = new int;
        top = 5;
        fraction.Fraction_c(top);
        Console.WriteLine(fraction.GetFractionString());
        int bottom = new int;
        bottom = 10;
        fraction.Fraction_c(bottom);
        Console.WriteLine(fraction.GetFractionString());
        
    }
}