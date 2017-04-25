using System;
//Write an expression that calculates rectangle’s area
//and perimeter by given width and height.
//The width and height should be read from the console.
//•The input will consist of 2 lines:
//◦On the first line, you will receive a floating-point number
//that will represent the width of the rectangle.
//◦On the second line, you will receive another floating-point
//number that will represent the height of the rectangle.
//•Output a single line - the rectangle's area and perimeter, separated by a whitespace.
//◦Print the area and perimeter values with exactly 2-digits precision after the floating point

class Rectangles
{
    static void Main()
    {
        double widthOfRectangle = double.Parse(Console.ReadLine());
        double heightOfRectangle = double.Parse(Console.ReadLine());
        double rectanglesArea = widthOfRectangle * heightOfRectangle;
        double rectanglesPerimeter = (2 * widthOfRectangle) + (2 * heightOfRectangle);
        Console.WriteLine("{0:0.00}" + " " + "{1:0.00}", rectanglesArea, rectanglesPerimeter);
        //double a = double.Parse(Console.ReadLine());                         //този го копнах-много кратък запис-работи
        //double b = double.Parse(Console.ReadLine());                         //този го копнах-много кратък запис-работи
        //Console.WriteLine("{0:0.00} {1:0.00}", (a * b), ((2 * a) + (2 * b)));//този го копнах-много кратък запис-работи
    }
}

