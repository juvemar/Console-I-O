//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormattingNumbers
{
    static void Main()
    {
        uint a;
        do
        {
            Console.Write("Write a nonnegative integer up to 500: ");
            a = uint.Parse(Console.ReadLine());
        } while (0 > a && a > 500);
            
            Console.Write("Write a floating number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write a second floating number: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0, -10:X}|{1, 10}|{2,10:N2}|{3,-10:N3}", a, Convert.ToString(a,2).PadLeft(10,'0'), b, c);
    }
}