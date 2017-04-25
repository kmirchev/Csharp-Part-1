using System;
//Write a program that reads from the console two integer numbers
//P and N and prints on the console the value of P's N-th bit.
//•On the first line you will receive the number P.
//On the second line you will receive the number N.
class Program
{
    static void Main()
    {

        long numberP = long.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(numberP, 2).PadLeft(32, '0'));
        int numberN = int.Parse(Console.ReadLine());
        long mask =  1 << numberN;
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        long pAndMask = numberP & mask;
        //Console.WriteLine(Convert.ToString(pAndMask, 2).PadLeft(32, '0'));
        long bit = pAndMask >> numberN;
        //Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));
        Console.WriteLine(bit);

        

    }
}

