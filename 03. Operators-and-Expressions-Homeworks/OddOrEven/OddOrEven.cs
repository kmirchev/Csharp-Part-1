using System;
//Write a program that reads an integer from the console,
//uses an expression to check if given integer is odd or even,
//and prints "even NUMBER" or "odd NUMBER",
//where you should print the input number's value instead of NUMBER.
class OddOrEven
{
    static void Main()
    {
        int number;
        number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("even" + " " + number);
            //Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("odd" + " " + number);
        }
    }
}

