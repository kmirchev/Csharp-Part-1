using System;

//Declare an integer variable and assign it with the value  254 
//in hexadecimal format( 0x## ). Use Windows Calculator to find
//its hexadecimal representation. 
//Print the variable and ensure that the result is  254 .

class VariableInHexadecimalFormat
{
    static void Main()
    {
        int a = 0xFE;// 254
        Console.WriteLine(a);

        int b = 0x3f7;//1015
        Console.WriteLine(b);

        int c = 0x1b;//27
        Console.WriteLine(c);

        int d = 0x9ae467;//10151015
        Console.WriteLine(d);

        int e = 0x9ae85f;//10152031
        Console.WriteLine(e);
    }
}

