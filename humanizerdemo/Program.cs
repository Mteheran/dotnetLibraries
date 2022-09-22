using System.Globalization;
using Humanizer;

var culture = new CultureInfo("es-ES");
var name = "miguel teheran";
var age = 1;
var salary = 1000;

//Console.WriteLine($"My Name is {name} and I am {age.ToWords()} years old ");
//Console.WriteLine($"Mi nombre es {name.Transform(To.TitleCase)} y tengo {age.ToWords(culture)} años ");
Console.WriteLine($@"Mi nombre es {name.Transform(To.TitleCase)} 
y tengo { "año".ToQuantity(age)} ");
Console.WriteLine($"Y mi salario es { "dollar".ToQuantity(salary, "C2") }");

