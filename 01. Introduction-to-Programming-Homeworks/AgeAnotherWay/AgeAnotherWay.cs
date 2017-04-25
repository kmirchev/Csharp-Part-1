using System;

    class AgeAnotherWay
    {
        static void Main()
        {
        DateTime input = DateTime.ParseExact(Console.ReadLine(), "mm.dd.yyyy", null);
        DateTime now = DateTime.Now;
        int age = now.Year - input.Year;
        if (input.DayOfYear > now.DayOfYear)
        {
            age--;
        }
        Console.WriteLine(age);
        Console.WriteLine(age +10);
        }
    }

