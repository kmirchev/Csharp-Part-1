using System;
//•A company has name, address, phone number, fax number,
//web site and manager. The manager has first name,
//last name, age and a phone number.
//•Write a program that reads the information about a company and
//its manager and prints it back on the console.
//•You will each piece of information about the company
//on a separate line, in the same order as in the example
//i.Company name
//ii.Company address
//iii.Phone number
//iv.Fax number
//v.Web site
//vi.Manager first name
//vii.Manager last name
//viii.Manager age
//ix.Manager phone


class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string phoneNumber = (Console.ReadLine());
        string faxNumber =(Console.ReadLine());        
        string webSite = Console.ReadLine();
        string managersFirstName = Console.ReadLine();
        string managersLastName = Console.ReadLine();
        byte managersAge = byte.Parse(Console.ReadLine());
        string managersPhoneNumber = (Console.ReadLine());
        

        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: " + "{0}", companyAdress);
        Console.WriteLine("Tel. " + "{0}", phoneNumber);       
        if (faxNumber == string.Empty)
        {
            Console.WriteLine("Fax: " + "(no fax)");
        }
        else
        {
            Console.WriteLine("Fax: " + faxNumber);
        }
        Console.WriteLine("Web site: " + "{0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managersFirstName, managersLastName, managersAge, managersPhoneNumber);
        

    }
}

