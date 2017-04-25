using System;
//Write a program that reads an integer N from the console
//and prints true if the third digit of N is 7, 
//or "false THIRD_DIGIT", where you should print the third digits of N.
//•The counting is done from right to left, meaning 123456's third digit is 4.

class ThirDigit
{
    static void Main()
    {
        uint thirdDigit = uint.Parse(Console.ReadLine());
        uint thirdDigit1 = thirdDigit / 100;
        uint thirdDigit2 = thirdDigit1 % 10;
        if (thirdDigit2 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdDigit2);
        }

    }
}

