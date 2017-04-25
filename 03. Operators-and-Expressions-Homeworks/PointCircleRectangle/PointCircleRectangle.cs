using System;
//Write a program that reads a pair of coordinates x and y
//and uses an expression to checks for given point (x, y)
//if it is within the circle  K({1, 1}, 1.5)
//and out of the rectangle  R(top=1, left=-1, width=6, height=2) .
class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double point = Math.Sqrt(((x-1)*(x-1)) + ((y-1)*(y-1)));

        //bool circleX = (x >= -0.5 && x <= 2.5);
        //bool circleY = (y >= -0.5 && y <= 2.5);
        

        bool rectangleX = (x >= -1 && x <= 5);
        bool rectangleY = (y >= -1 && y <= 1);

        bool circle = (point <= 1.5);
        bool rectangle = (rectangleX && rectangleY);

      
        ////Console.WriteLine(circle && rectangle ? ("inside circle" + " " + "inside rectangle") : ("outside circle" + " " + "outside rectangle"));

        if (circle == true)
        {
            if (rectangle == true)
            {
                Console.WriteLine("inside circle" + " " + "inside rectangle");
            }
            else
            {
                Console.WriteLine("inside circle" + " " + "outside rectangle");
            }
        }
        else
        {
            if (circle == false)
            {
                if (rectangle == false)
                {
                    Console.WriteLine("outside circle" + " " + "outside rectangle");
                }
                else
                {
                    Console.WriteLine("outside circle" + " " + "inside rectangle");
                }
            }
        }
    }
}
