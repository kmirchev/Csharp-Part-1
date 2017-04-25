using System;
//Find online more information about ASCII
//(American Standard Code for Information Interchange)
//and write a program that prints the visible characters
//of the ASCII table on the console (characters from  33  to  126  including).
class PrintТheASCIITable
{
    static void Main()
    {
        //char aSCII = '\u0021';
        for (char aSCII = '\u0021'; aSCII <= 126; aSCII++)
            Console.Write(aSCII);
        //for (char symbolaSCII = '\u007e'; symbolaSCII >= 33; symbolaSCII--)
        //    Console.Write(symbolaSCII);
    }
}

