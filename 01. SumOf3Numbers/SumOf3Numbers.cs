//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Please write the first real number:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please write the second real number:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please write the third real number:");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("The sum of your numbers is: {0} ", sum);
    }
}