//Write a program that reads the radius r of a circle and
//prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * (Math.PI) * r;
        double area = (Math.PI) * Math.Pow(r, 2);
        Console.WriteLine("The perimeter is: {0:N2}\nThe area is: {1:N2}", perimeter, area);
    }
}
