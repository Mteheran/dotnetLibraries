using Humanizer;

List<BookChapter> harryPotter = new List<BookChapter>();
harryPotter.Add(new BookChapter()
{
    ChapterNumber = "I",
    Title = "El Niño que Vivió"
});
harryPotter.Add(new BookChapter()
{
    ChapterNumber = "II",
    Title = "El Vidrio que se Desvaneció"
});
harryPotter.Add(new BookChapter()
{
    ChapterNumber = "III",
    Title = "Las Cartas de Nadie"
});
harryPotter.Add(new BookChapter()
{
    ChapterNumber = "IV",
    Title = "El Guardián de las Llaves"
});

foreach(var item in harryPotter)
{
    Console.WriteLine($"{item.ChapterNumber.FromRoman()}. {item.Title}");
}


public class BookChapter 
{
    public string ChapterNumber {get;set;}
    public string Title {get;set;}
}