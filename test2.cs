using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            var t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("GCD for two number");
        Console.Write("enter the first number - ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the second number - ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Greatest common divisor of numbers {0} and {1} is equal {2}", a, b, GCD(a, b));
        Console.ReadLine();
    }
}
