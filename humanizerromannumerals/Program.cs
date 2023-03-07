List<BookChapter> harryPotter = new List<BookChapter>();
harryPotter.Add(new BookChapter()
{
    ChapterNumber = 1,
    Title = "El Niño que Vivió"
});
harryPotter.Add(new BookChapter()
{
    ChapterNumber = 2,
    Title = "El Vidrio que se Desvaneció"
});
harryPotter.Add(new BookChapter()
{
    ChapterNumber = 3,
    Title = "Las Cartas de Nadie"
});
harryPotter.Add(new BookChapter()
{
    ChapterNumber = 4,
    Title = "El Guardián de las Llaves"
});

foreach(var item in harryPotter)
{
    Console.WriteLine($"{item.ChapterNumber}. {item.Title}");
}


public class BookChapter 
{
    public int ChapterNumber {get;set;}
    public string Title {get;set;}
}