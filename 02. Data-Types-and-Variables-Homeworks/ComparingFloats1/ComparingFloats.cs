using System;
//Write a program that safely compares two floating-point
//numbers (double) with precision  eps = 0.000001 .
//Note: Two floating-point numbers  a and  b cannot be 
//compared directly by  a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely 
//to each other than a fixed constant eps .
class ComparingFloats
{
    static void Main()
    {
        //double firstFPN = double.Parse(Console.ReadLine());
        //double secondFPN = double.Parse(Console.ReadLine());
        //if (Math.Abs(firstFPN - secondFPN) < 0.000001)
        //{
        //    Console.WriteLine("true");
        //}
        //else
        //{
        //    Console.WriteLine("false");
        //}

        //second variant
        double firstFPN = double.Parse(Console.ReadLine());
        double secondFPN = double.Parse(Console.ReadLine());
        bool firstSecond = Math.Abs(firstFPN - secondFPN) < 0.000001;
        Console.WriteLine(firstSecond.ToString().ToLower());//изписва резултата с малки букви
        Console.WriteLine(firstSecond.ToString().ToUpper());//изписва резултата с главни букви
    }
}

