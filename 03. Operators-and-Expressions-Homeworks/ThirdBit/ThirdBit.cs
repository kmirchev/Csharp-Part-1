using System;
//Using bitwise operators, write a program that uses an expression
//to find the value of the bit at index 3 of an unsigned integer read from the console.
//•The bits are counted from right to left, starting from bit 0.
//•The result of the expression should be either 1 or 0. Print it on the console.

class ThirdBit
{
    static void Main()
    {

        uint index = 1;
        //Console.WriteLine(Convert.ToString(index, 2).PadLeft(32, '0'));
        uint thirdBit = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(thirdBit, 2).PadLeft(32, '0'));
        uint mask = index << 3;
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        uint numberAndMask = thirdBit & mask;
        //Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
        uint bit = numberAndMask >> 3;
        //Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));
        Console.WriteLine(bit);
    }
}

