using System;


class Program
{
    static void Main()
    {
        try
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("2 * {0} = {1}", a, 2 * a);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            //Console.WriteLine("The input is not a number");
        }
    }
}

