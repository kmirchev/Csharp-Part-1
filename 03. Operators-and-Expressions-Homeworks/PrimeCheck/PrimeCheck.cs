using System;
//Write a program that reads an integer N
//(which will always be less than 100 or equal)
//and uses an expression to check if given N is prime
//(i.e. it is divisible without remainder only to itself and 1).
//•Note: You should check if the number is positive

class PrimeCheck //това е копиран чужд код
{
    static void Main()
    {
        int prime = int.Parse(Console.ReadLine());

        if (prime > 0 && prime <= 100)
        {
            if (prime == 0 || prime == 1)
            {
                Console.WriteLine("false");
                return;
            }
            else
            {
                for (int a = 2; a <= prime / 2; a++)
                {
                    if (prime % a == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }

                }
                Console.WriteLine("true");
            }
        }
        else
        {
            Console.WriteLine("false");
        }

    }
}


