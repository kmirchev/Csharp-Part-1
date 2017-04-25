using System;
//Write a program that takes as input a four-digit number
//in format abcd (e.g. 2011) and performs the following:
//1.Calculates the sum of the digits(in our example
//2 + 0 + 1 + 1 = 4 ) and prints it on the console.
//2.Prints on the console the number in reversed order:
//dcba (in our example 1102) and prints the reversed number.
//3.Puts the last digit in the first position:
//dabc(in our example 1201) and prints the result.
//4.Exchanges the second and the third digits:
//acbd (in our example 2101) and prints the result.

class FourDigits
{
    static void Main()
    {
        //string fourDigitNumber = Console.ReadLine();
        //string a = fourDigitNumber[0].ToString();
        //string b = fourDigitNumber[1].ToString();
        //string c = fourDigitNumber[2].ToString();
        //string d = fourDigitNumber[3].ToString();

        //int sumFourDigit = fourDigitNumber[0] + fourDigitNumber[1] + fourDigitNumber[2] + fourDigitNumber[3] - 48 * 4;
        //Console.WriteLine(sumFourDigit);
        //Console.WriteLine(d+c+b+a);
        //Console.WriteLine(d+a+b+c);
        //Console.WriteLine(a+c+b+d);

        int fourDigitNumber = int.Parse(Console.ReadLine());
        int firstNumber = ((fourDigitNumber / 1000) % 10);
        int secondNumber = ((fourDigitNumber / 100) % 10);
        int thirdNumber = ((fourDigitNumber / 10) % 10);
        int fourthNumber = (fourDigitNumber % 10);
        //Console.WriteLine("{0},{1},{2},{3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
        //Console.WriteLine("{0}", firstNumber + secondNumber + thirdNumber + fourthNumber);
        int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
        Console.WriteLine("{0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("{0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
    }
}
