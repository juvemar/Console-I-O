//Write a program that reads the coefficients a, b and c of a quadratic equation
//ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        double x1;
        double x2;
        Console.Write("Enter a number for \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number for \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a number for \"c\": ");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - 4 * a * c;
        if (d >= 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            if (x1 == x2)
            {
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
        }
        else
            Console.WriteLine("There are no real roots.");
        
    }
}