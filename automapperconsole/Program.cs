using AutoMapper;
using AutoMapper.Configuration.Annotations;

var newPerson = new Person() { Name= "Maria", LastName = "Lopez", Age=20};

var configMapper = new MapperConfiguration(cfg=> cfg.AddMaps("automapperconsole"));
                                                    //cfg.CreateMap<Person, User>()
                                                    //.ForMember(dest=> dest.FirstName, opt=> opt.MapFrom(src=> src.Name))
                                                    //.ForMember(dest=> dest.UserName, opt=> opt.MapFrom(src=> src.Name + src.LastName)));
var mapper = new Mapper(configMapper);

var newUser = mapper.Map<User>(newPerson);


Console.WriteLine($"Nombre: {newUser.FirstName} ");
Console.WriteLine($"Apellido: {newUser.LastName} ");
Console.WriteLine($"Usuario: {newUser.UserName} ");

[AutoMap(typeof(Person))]
public class User
{
    [SourceMember("Name")]
    public string FirstName {get;set;}
    public string LastName {get;set;}

     [SourceMember("Name")]
    public string UserName {get;set;} 
}

public class Person
{
    public string Name {get;set;}
    public string LastName {get;set;}
    public int Age {get;set;}

}