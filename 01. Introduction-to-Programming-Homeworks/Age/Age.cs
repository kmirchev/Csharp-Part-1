using System;

class Age
{
    static void Main()
    {
        //Console.WriteLine("Enter your birthday date in format MM.dd.yyyy:");
        DateTime birth = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
        DateTime now = DateTime.Now;
        int age = now.Year - birth.Year;
        if (now.Month <= birth.Month && now.Day < birth.Day)
        {
            age--;
        }
        Console.WriteLine("{0}\n{1}", age, age + 10);
    }
}


