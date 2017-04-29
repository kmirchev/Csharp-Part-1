using System;

class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double sumOfNumbers = 0;

        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sumOfNumbers += num;
        }
        Console.WriteLine(sumOfNumbers);
    }
}

