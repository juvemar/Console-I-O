//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("Write how many numbers you want to enter:" );
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter your numbers: ", n);
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is " + sum);

    }
}