using System.Globalization;
using Humanizer;

var culture = new CultureInfo("es-ES");
var name = "miguel teheran";
var age = 30;

//Console.WriteLine($"My Name is {name} and I am {age.ToWords()} years old ");
Console.WriteLine($"Mi nombre es {name.Transform(To.TitleCase)} y tengo {age.ToWords(culture)} años ");