//Write a program that reads two positive integer numbers
//and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInInterval
{
    static void Main()
    {
        uint lower;
        uint upper;
        uint i = 0;
        int counter = 0;//counter = p(the number of integers in the interval which are devidable by 5)
        do
        {
            Console.Write("Enter your first positive integer for the lower limit: ");
            lower = uint.Parse(Console.ReadLine());
            Console.Write("Enter your second positive integer for the upper limit: ");
            upper = uint.Parse(Console.ReadLine());
        }while(lower > upper || lower<1);

        for(i=lower;i<=upper;i++)
        {
            if(i%5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("{0} numbers divide by 5 without a remainder", counter);
    }
}