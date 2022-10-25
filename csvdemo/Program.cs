// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    HasHeaderRecord = false,
    Delimiter = "|"
};

using (var reader = new StreamReader("users.csv"))
{
    using (var csv = new CsvReader(reader, config))
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
     [Name("Login email")]
     [Index(1)]
    public string LoginEmail {get;set;}

    [Name("Username")]
    [Index(0)]
    public string UserName { get;set;}
   
    [Index(2)]
    public short Identifier {get;set;}

     [Index(3)]
    [Name("First name")]
    public string FirstName {get;set;}

    [Index(4)]
    [Name("Last name")]
    public string LastName { get;set;}

}