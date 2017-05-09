using System;
//Write a program that reads two positive integer numbers N and M
//and prints how many numbers exist between them
//such that the reminder of the division by 5 is 0.
class Interval
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint m = uint.Parse(Console.ReadLine());
        var num = 0;

        for (uint i = n + 1; i < m; i++)
        {
            if (i % 5 == 0)
            {
                num++;
            }           
        }
        Console.WriteLine(num);
    }
}

