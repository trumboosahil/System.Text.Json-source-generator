// See https://aka.ms/new-console-template for more information
using JSONSourceCodeGenrators;
using System.Text.Json;

Console.WriteLine("Hello, World!");
Person person = new() { Name = "Shafi", FirstName = "Trumboo" };
string json = JsonSerializer.Serialize(person, PersonJSonContext.Default.Person);
Console.WriteLine(json);
Console.ReadLine();

