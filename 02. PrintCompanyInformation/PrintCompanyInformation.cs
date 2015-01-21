/*A company has name, address, phone number, fax number, web site and manager.
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Company manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Company manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge= Console.ReadLine();
        Console.Write("Manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        string space = new string('-', 60);
        Console.WriteLine(space);

        Console.Clear();
        
        Console.WriteLine("{0}\nAddress: {1}\nAddress: {2}\nFax: {3}\nWeb site: {4}"
                    , companyName, companyAddress, companyPhoneNumber, companyFax, companyWebSite);
        Console.WriteLine("\nManager: {0} {1} (age: {2} tel. {3})."
                    , managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}