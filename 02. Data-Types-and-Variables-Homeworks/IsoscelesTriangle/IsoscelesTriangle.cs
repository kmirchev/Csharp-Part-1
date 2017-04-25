using System;
using System.Text;
//Write a program that prints an isosceles triangle of 9 copyright symbols  © , something like this:

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("   ©   ");
        Console.WriteLine("  © ©  ");
        Console.WriteLine(" ©   © ");
        Console.WriteLine("© © © ©");
        //Console.WriteLine("   \u00A9   ");
        //Console.WriteLine("  \u00A9 \u00A9  ");
        //Console.WriteLine(" \u00A9   \u00A9 ");
        //Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");

    }
}

