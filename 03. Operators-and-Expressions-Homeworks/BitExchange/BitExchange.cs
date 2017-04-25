using System;
//Write a program that exchanges bits 3, 4 and 5
//with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).

class BitExchange
{
    static void Main()
    {    // variant 1
         //uint number = uint.Parse(Console.ReadLine());
         ////Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
         //uint mask3 = 7 << 3;
         ////Console.WriteLine(Convert.ToString(mask3, 2).PadLeft(32, '0'));
         //uint mask24 = 7 << 24;
         ////Console.WriteLine(Convert.ToString(mask24, 2).PadLeft(32, '0'));
         //uint mask3And24 = ~((7U << 24) | (7U << 3));
         ////Console.WriteLine(Convert.ToString(mask3And24, 2).PadLeft(32, '0'));
         //uint numberAndMask3 = (number & mask3);
         ////Console.WriteLine(Convert.ToString(numberAndMask3, 2).PadLeft(32, '0'));
         //uint numberAndMask24 = (number & mask24);
         ////Console.WriteLine(Convert.ToString(numberAndMask24, 2).PadLeft(32, '0'));
         //uint number1 = numberAndMask3 << 21;
         ////Console.WriteLine(Convert.ToString(number1, 2).PadLeft(32, '0'));
         //uint number2 = numberAndMask24 >> 21;
         ////Console.WriteLine(Convert.ToString(number2, 2).PadLeft(32, '0'));
         ////Console.WriteLine(Convert.ToString(zero, 2).PadLeft(32, '0'));
         //uint number3 = (number1 | 0);
         ////Console.WriteLine(Convert.ToString(number3, 2).PadLeft(32, '0'));
         //uint number4 = (number2 | number3);
         ////Console.WriteLine(Convert.ToString(number4, 2).PadLeft(32, '0'));
         //uint numberAndnumber4 = number & mask3And24;
         ////Console.WriteLine(Convert.ToString(numberAndnumber4, 2).PadLeft(32, '0'));
         //uint finalNumber = number4 | numberAndnumber4;
         ////Console.WriteLine(Convert.ToString(finalNumber, 2).PadLeft(32, '0'));
         //Console.WriteLine(finalNumber);
         //    }
         //}


        //variant 3

        
        uint number = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        uint index = 1;
        index = (index << 3) -1;
        //Console.WriteLine(Convert.ToString(index, 2).PadLeft(32, '0'));
        //uint closePosition = 3;
        //uint farPosition = 24;      

        uint maskClose = index << 3;
        //Console.WriteLine(Convert.ToString(maskClose, 2).PadLeft(32, '0'));
        uint closeBitValue = (number & maskClose) >> 3;
        //Console.WriteLine(Convert.ToString(closeBitValue, 2).PadLeft(32, '0'));

        uint maskFar = index << 24;
        //Console.WriteLine(Convert.ToString(maskFar, 2).PadLeft(32, '0'));
        uint farBitValue = (number & maskFar) >> 24;
        //Console.WriteLine(Convert.ToString(farBitValue, 2).PadLeft(32, '0'));
        uint invertedClose = ~maskClose;
        //Console.WriteLine(Convert.ToString(invertedClose, 2).PadLeft(32, '0'));
        number = number & invertedClose;
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        uint invertedFar = ~maskFar;
        //Console.WriteLine(Convert.ToString(invertedFar, 2).PadLeft(32, '0'));
        number = number & invertedFar;
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        closeBitValue = closeBitValue << 24;
        number = number | closeBitValue;
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        farBitValue = farBitValue << 3;
        number = number | farBitValue;
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }
}
//        // variant 2
//        uint number = uint.Parse(Console.ReadLine());
//        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
//        uint mask = 1 << 3;
//        uint thirdBit = (number & mask) >> 3;
//        mask = 1 << 4;
//        uint fourthBit = (number & mask) >> 4;
//        mask = 1 << 5;
//        uint fifthBit = (number & mask) >> 5;

//        mask = 1 << 24;
//        uint twentyFourthBit = (number & mask) >> 24;
//        mask = 1 << 25;
//        uint twentyFifthBit = (number & mask) >> 25;
//        mask = 1 << 26;
//        uint twentySixthBit = (number & mask) >> 26;
//       //Console.WriteLine("{5},{4},{3},{2},{1},{0}", thirdBit, fourthBit, fifthBit, twentyFourthBit, twentyFifthBit, twentySixthBit);

//        if (thirdBit == 0)
//        {
//            // put 0 on 24th position
//            mask = 1 << 24;
//            number = number & ~mask;
//        }
//        else if (thirdBit == 1)
//        {
//            // put 1 on 24th position
//            mask = 1 << 24;
//            number = number | mask;

//        }
//        if (twentyFourthBit == 0)
//        {
//            //put 0 on third position
//            mask = 1 << 3;
//            number = number & ~mask;
//        }
//        else if (twentyFourthBit == 1)
//        {
//            //put 1 on third position
//            mask = 1 << 3;
//            number = number | mask;
//        }
//        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
//        if (fourthBit == 0)
//        {
//            // put 0 on 25th position
//            mask = 1 << 25;
//            number = number & ~mask;
//        }
//        else if (fourthBit == 1)
//        {
//            // put 1 on 25th position
//            mask = 1 << 25;
//            number = number | mask;
//                    }
//        if (twentyFifthBit == 0)
//        {
//            //put 0 on 4th position
//            mask = 1 << 4;
//            number = number & ~mask;
//        }     
//        else if (twentyFifthBit == 1)
//        {
//            // put 1 on 4th position
//            mask = 1 << 4;
//            number = number | mask;
//        }
//        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
//        if (fifthBit == 0)
//        {
//            // put 0 on 26th position
//            mask = 1 << 26;
//            number = number & ~mask;
//        }
//        else if (fifthBit == 1)
//        {
//            // put 1 on 26th position
//            mask = 1 << 26;
//            number = number | mask;
//        }
//        if (twentySixthBit == 0)
//        {
//            //put 0 on 5th position
//            mask = 1 << 5;
//            number = number & ~mask;
//        }
//        else if (twentySixthBit == 1)
//        {
//            // put 1 on 5th position
//            mask = 1 << 5;
//            number = number | mask;
//        }
//        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
//        Console.WriteLine(number);
//    }
//}
