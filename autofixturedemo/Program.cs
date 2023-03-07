using AutoFixture;

Fixture fixture = new Fixture();

var user = fixture.Build<User>()
        .With(p=> p.DateCreated, DateTime.Now.AddDays(-60))
        .Without(p=> p.Email).Create();

Console.WriteLine($"Name: {user.Name}");
Console.WriteLine($"Email: {user.Email}");
Console.WriteLine($"NumberOfLogins: {user.NumberOfLogins}");
Console.WriteLine($"DateCreated: {user.DateCreated}");

public class User 
{
    public string Name {get;set;}
    public string Email {get;set;}
    public int NumberOfLogins  { get;set;}
    public DateTime DateCreated {get;set;}
}