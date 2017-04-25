using System;
//Write an expression that calculates trapezoid's area
//by given sides a and b and height h. The three values
//should be read from the console in the order shown below.
//All three value will be floating-point numbers.
//•The input will consist of exactly 3 lines:
//i.The side a on the first line.
//ii.The side b on the second line.
//iii.The height h on the third line.

class Trapezoids //A = ((a+b)*height) /2
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double sumAB = (sideA + sideB);
        double trapezoidsArea = (sumAB * height) / 2;
        Console.WriteLine("{0:F7}", trapezoidsArea);
    }
}

