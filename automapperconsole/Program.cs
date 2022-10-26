using AutoMapper;
var newPerson = new Person() { Name= "Maria", LastName = "Lopez", Age=20};

var configMapper = new MapperConfiguration(cfg=> cfg.CreateMap<Person, User>());
var mapper = new Mapper(configMapper);

var newUser = mapper.Map<User>(newPerson);


Console.WriteLine($"Nombre: {newUser.Name} ");
Console.WriteLine($"Apellido: {newUser.LastName} ");
Console.WriteLine($"Usuario: {newUser.UserName} ");

public class User
{
    public string Name {get;set;}
    public string LastName {get;set;}
    public string UserName {get;set;} 
}

public class Person
{
    public string Name {get;set;}
    public string LastName {get;set;}
    public int Age {get;set;}

}