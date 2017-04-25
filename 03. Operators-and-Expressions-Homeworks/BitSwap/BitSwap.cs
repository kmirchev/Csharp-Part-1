using System;
//Write a program first reads 4 numbers n, p, q and k
//and than swaps bits  {p, p+1, …, p+k-1}  with bits
//{q, q+1, …, q+k-1}  of n.
//Print the resulting integer on the console.
class BitSwap
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());                                 //inputs numbers
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0')); 
        uint p = uint.Parse(Console.ReadLine());                                 //inputs numbers
        uint q = uint.Parse(Console.ReadLine());                                 //inputs numbers
        uint k = uint.Parse(Console.ReadLine());                                 //inputs numbers

        uint numberOfBits = (k);
        //Console.WriteLine(numberOfBits);
        numberOfBits = (1U << Convert.ToInt32(numberOfBits)) - 1;                //generate now many bits we'll use
        //Console.WriteLine(Convert.ToString(numberOfBits, 2).PadLeft(32,'0'));

        uint maskP = numberOfBits << Convert.ToInt32(p);                         //generate mask of p-bits
        //Console.WriteLine(Convert.ToString(maskP, 2).PadLeft(32, '0'));

        uint pBitValue = (n & maskP) >> Convert.ToInt32(p);                      //gets p-bits
        //Console.WriteLine(Convert.ToString(pBitValue, 2).PadLeft(32, '0'));

        uint maskQ = numberOfBits << Convert.ToInt32(q);                         //generate mask of q-bits
        //Console.WriteLine(Convert.ToString(maskQ, 2).PadLeft(32, '0'));

        uint qBitValue = (n & maskQ) >> Convert.ToInt32(q);                      //gets q-bits
        //Console.WriteLine(Convert.ToString(qBitValue, 2).PadLeft(32, '0'));

        n = n & ~maskP;                                                          //clear bits of p-position
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        n = n & ~maskQ;                                                          //clear bits of q-position
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        pBitValue = pBitValue << Convert.ToInt32(q);                             //moves p-bits on q-position
        //Console.WriteLine(Convert.ToString(pBitValue, 2).PadLeft(32, '0'));
        qBitValue = qBitValue << Convert.ToInt32(p);                             //moves q-bits on p-position
        //Console.WriteLine(Convert.ToString(qBitValue, 2).PadLeft(32, '0'));

        n = n | pBitValue;                                                       //sets p-bits
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        n = n | qBitValue;                                                       //sets q-bits
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(n);                                                    //result - 100/100 in BGCoder :)
    }
}
