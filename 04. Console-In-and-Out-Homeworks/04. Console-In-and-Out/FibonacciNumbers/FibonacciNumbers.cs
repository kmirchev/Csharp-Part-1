using System;
//Write a program that reads a number N and prints
//on the console the first N members of the Fibonacci
//sequence (at a single line, separated by comma and
//space - ", ") :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .
class FibonacciNumbers
{
    static void Main()

    {
        int N = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 0;

        if (N == 1)
        {
            Console.Write("{0}", 0);
        }
        else
        {

            Console.Write("{0}, {1}", a, b);

            for (int i = 0; i < N - 2; i++)
            {
                c = a + b;
                Console.Write(", {0}", c);
                a = b;
                b = c;

            }
        }

    }
}

