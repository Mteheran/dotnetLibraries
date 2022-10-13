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
            dt.Columns.Add("Username" , typeof(string)); 
            dt.Columns.Add("Login email" , typeof(string)); 
            dt.Columns.Add("Identifier" , typeof(short)); 
            dt.Columns.Add("First name" , typeof(string)); 
            dt.Columns.Add("Last name" , typeof(string));   

            dt.Load(dr);

           for (int i = 0; i < dt.Rows.Count; i++)
           {
                Console.WriteLine($"{dt.Rows[i][0]} - {dt.Rows[i][2]}");
           }
        }
    }
}