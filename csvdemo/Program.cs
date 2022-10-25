// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

using (var reader = new StreamReader("users.csv"))
{
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        var listUsersFromCsv = csv.GetRecords<User>().ToList();

        foreach (var item in listUsersFromCsv)
        {
            Console.WriteLine($"{item.UserName} - {item.Identifier}");
        } 
    }
}

public class User
{
    [Name("Username")]
    public string UserName { get;set;}

    [Name("Login email")]
    public string LoginEmail {get;set;}
    public short Identifier {get;set;}

    [Name("First name")]
    public string FirstName {get;set;}

    [Name("Last name")]
    public string LastName { get;set;}

}