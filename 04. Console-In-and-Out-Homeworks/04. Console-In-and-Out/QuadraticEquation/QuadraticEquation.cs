using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = ((b * b) - (4 * a * c));
        if (d > 0)
        {
            double root1 = ((-b + Math.Sqrt(d)) / (2 * a));
            double root2 = ((-b - Math.Sqrt(d)) / (2 * a));

            double compareRootMin = (Math.Min(root1, root2));
            double compareRootMax = (Math.Max(root1, root2));
            Console.WriteLine("{0:F2}", compareRootMin);
            Console.WriteLine("{0:F2}", compareRootMax);
        }
        else if (d == 0)
        {
            double root = -(b / (2 * a));
            Console.WriteLine("{0:F2}",root);
        }
        else if (d<0)
        {
            Console.WriteLine("no real roots");
        }
    }
}

