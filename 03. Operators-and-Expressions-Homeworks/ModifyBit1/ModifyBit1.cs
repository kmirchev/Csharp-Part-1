using System;
//We are given an integer number N (read from the console),
//a bit value v (read from the console as well) (v = 0 or 1)
//and a position P (read from the console). Write a sequence
//of operators (a few lines of C# code) that modifies N
//to hold the value v at the position P from the binary representation of N
//while preserving all other bits in N. Print the resulting number on the console.
class ModifyBit1
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        uint P = uint.Parse(Console.ReadLine());
        sbyte V = sbyte.Parse(Console.ReadLine());

        ulong mask = 1UL << (int)P;
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        ulong reverseMask = ~(1UL << (int)P);
        //Console.WriteLine(Convert.ToString(reverseMask, 2).PadLeft(32, '0'));

        if (V == 0)
        {
            Console.WriteLine(reverseMask & number);
            //Console.WriteLine(Convert.ToString(reverseMask & number, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine(mask | number);
            //Console.WriteLine(Convert.ToString(mask | number, 2).PadLeft(32, '0'));
        }
    }
}

