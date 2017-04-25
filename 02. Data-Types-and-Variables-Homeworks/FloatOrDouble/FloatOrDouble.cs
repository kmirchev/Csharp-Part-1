using System;

class FloatOrDouble
{
    static void Main()
    {
        //Which of the following values can be assigned to a variable
        //of type  float  and which to a variable of type  double :
        //34.567839023, 12.345, 8923.1234857, 3456.091 ?
        //Write a program to assign the numbers in variables and
        //print them to ensure no precision is lost.

        //double a = 34.567839023;
        //int e = 1;
        //double sum = 35.567839023;
        //bool equal = (a + e == sum);
        //Console.WriteLine("a + e = {0} sum = {1} equal = {2}", a + e, sum, equal); //True

        float b = 12.345f;
        int e = 1;
        double sum = 13.345;
        //bool equal = (b + e == sum);
        bool equal = ((b + e - sum) < 0.00000000001);// Ако го запишем по този начин,
        //като зададем до коя цифра след запетаята да е точността ( до определена граница ) е - True 
        Console.WriteLine("b + e = {0} sum = {1} equal = {2}", b + e, sum, equal); //False

        //double c = 8923.1234857;
        //int e = 1;
        //double sum = 8924.1234857;
        //bool equal = (c + e == sum);
        //Console.WriteLine("c + e = {0} sum = {1} equal = {2}", c + e, sum, equal); //True

        //float d = 3456.091f;
        //int e = 1;
        //double sum = 3457.091;
        //bool equal = (d + e == sum);
        //Console.WriteLine("d + e = {0} sum = {1} equal = {2}", d + e, sum, equal); //False



    }
}

