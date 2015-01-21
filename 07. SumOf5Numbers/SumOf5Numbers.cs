//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Write 5 numbers with space between them: ");
        string numbers = Console.ReadLine();
        string[] separateNumbers = numbers.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
        int i;
        double sum = 0; 
        for (i = 0; i < separateNumbers.Length;i++)
        {
            sum += double.Parse(separateNumbers[i]);
        }
        Console.WriteLine("The sum is: " + sum);

    }
}