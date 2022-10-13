// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Globalization;
using CsvHelper;

using (var reader = new StreamReader("users.csv"))
{
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        using(var dr = new CsvDataReader(csv))
        {
            var dt =  new DataTable();
            dt.Load(dr);

            Console.WriteLine($"{dt.Rows[0][0]}");
        }
    }
}