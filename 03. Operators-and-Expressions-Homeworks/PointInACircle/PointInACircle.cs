using System;
//Write a program that reads the coordinates of a point x and y
//and using an expression checks if given point (x, y) is inside a circle
//K({0, 0}, 2)  - the center has coordinates (0, 0) and the circle has radius 2.
//The program should then print "yes DISTANCE" if the point is inside the circle
//or "no DISTANCE" if the point is outside the circle.
//•In place of DISTANCE print the distance from the beginning
//of the coordinate system - (0, 0) - to the given point.


class PointInACircle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double d = Math.Sqrt ((a * a) + (b * b));
       // Console.WriteLine(d);
        bool a1 = ((a >= -2) && (a <= 2));
        bool b1 = ((b >= -2) && (b <= 2));
        bool d1 = (d <= 2);
        if (a1 && b1 && d1 == true)
        {
            Console.WriteLine("yes" + " " + "{0:0.00}", d);
        }
        else
        {
            Console.WriteLine("no" + " " + "{0:0.00}", d);
        }
    }
}

