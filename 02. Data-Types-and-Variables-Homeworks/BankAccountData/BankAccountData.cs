using System;
//A bank account has a holder name (first name, middle name and last name),
//available amount of money (balance), bank name, IBAN, 3 credit card numbers
//associated with the account. Declare the variables needed to keep the
//information for a single bank account using
//the appropriate data types and descriptive names.
class BankAccountData
{
    static void Main()
    {
        string fullName = "Konstantin Nikolov Mirchev";
        decimal availableMoney = 100.27M;
        string bankName = "My Bank";
        var iBan = "bg11ffff11111111111111";
        ulong creditCard1 = 2222222222222222;
        ulong creditCard2 = 3333333333333333;
        ulong creditCard3 = 4444444444444444;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n", fullName,
            availableMoney, bankName, iBan, creditCard1, creditCard2, creditCard3);
        //Console.WriteLine("{0}\n{1}\n{2}\n", creditCard1, creditCard2, creditCard3);
        //Console.WriteLine("{0}\n{1}\n{2}\n", creditCard3, creditCard2, creditCard1);
        //Console.WriteLine("{1}\n{0}\n{2}\n", creditCard1, creditCard2, creditCard3);
    }
}

