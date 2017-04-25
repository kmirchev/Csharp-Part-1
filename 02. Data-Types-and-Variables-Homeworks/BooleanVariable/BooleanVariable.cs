using System;
//Declare a Boolean variable called  isFemale 
//and assign an appropriate value corresponding
//to your gender. Print it on the console.

class BooleanVariable
{
    static void Main()
    {

        string myGender = "male";
        string gender = "female";
        bool isFemale = (myGender == gender);
        Console.WriteLine(isFemale);

        //bool isFemale;
        //Console.WriteLine("Enter your gender - male or female:");
        //string gender = Console.ReadLine();

        //if (gender == "male")
        //{
        //    isFemale = false; Console.WriteLine(isFemale + " " + "You are not female.");
        //}
        //else
        //{
        //    isFemale = true; Console.WriteLine(isFemale + " " + " You are Female.");
        //}
    }
}

