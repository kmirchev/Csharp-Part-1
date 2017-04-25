using System;

//Declare a character variable and assign it with the symbol
//that has Unicode code  42  (decimal) using
//the  \u00XX  syntax, and then print it.

class UnicodeCharacter
{
    static void Main()
    {
        char a = '\u002A';//42 prints *
        Console.WriteLine(a);

        char b = '\u0025';//37 prints %
        Console.WriteLine(b);

        char c = '\u0023';//35 prints #
        Console.WriteLine(c);

        char d = '\u002f';//47 prints /
        Console.WriteLine(d);


    }
}

