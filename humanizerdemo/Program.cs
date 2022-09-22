using System.Globalization;
using Humanizer;

var culture = new CultureInfo("es-ES");
var name = "miguel teheran";
var age = 1;
var salary = 1000;

//Console.WriteLine($"My Name is {name} and I am {age.ToWords()} years old ");
//Console.WriteLine($"Mi nombre es {name.Transform(To.TitleCase)} y tengo {age.ToWords(culture)} años ");
Console.WriteLine($@"Mi nombre es {name.Transform(To.TitleCase)} 
, tengo { "año".ToQuantity(age)} ");
Console.WriteLine($", mi salario es { "dollar".ToQuantity(salary, "C2") }");
Console.WriteLine($", soy el { 2.ToOrdinalWords(culture) } de 2 hermanos");
Console.WriteLine($"y mi hermana es la { 1.ToOrdinalWords(GrammaticalGender.Masculine, culture) } ");