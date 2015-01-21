//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        double b = double.Parse(Console.ReadLine());

        bool check = a>b;
        Console.WriteLine(check ? a : b);
        
    }
}