﻿using System;

class PrintSequence
{
    static void Main()
    {
        //Console.WriteLine("2");
        //Console.WriteLine("-3");
        //Console.WriteLine("4");
        //Console.WriteLine("-5");
        //Console.WriteLine("6");
        //Console.WriteLine("-7");
        //Console.WriteLine("8");
        //Console.WriteLine("-9");
        //Console.WriteLine("10");
        //Console.WriteLine("-11");

       // Console.WriteLine("or");

        for (int i = 2; i <= 11; i++)


            if (i % 2 == 0)

            {
                Console.WriteLine(i);
            }

            else

            {
                Console.WriteLine(-i);
            }
    }

}

