// See https://aka.ms/new-console-template for more information
using Pontkalkulator.Models;
using Pontkalkulator.Repos;

Console.WriteLine("Hello, World!");
StudentCreditRepo strepo = new StudentCreditRepo();

StudentCredit first = new StudentCredit("Kis Anna", "neptunkod123", 43);

Console.WriteLine("Osztály készítése: " + "\n");
try
{
    Console.WriteLine(first);
    first.SetName("Nagy Piroska");
    first.SetNeptunCode("ABSC1564");
    Console.WriteLine(first);
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}

if(first.IsFinished() == true)
    Console.WriteLine("Félév teljesítve.");
else
Console.WriteLine($"Félév nem teljesítve. {first.LeftCredit()} credit hiányzik a félév teljesítéséhez.");

Console.Write("Adjon meg egy kurzus kreditértéket: ");
int coursePoint = Convert.ToInt32(Console.ReadLine());
first.IncreaseCredit(coursePoint);
Console.WriteLine(first);

Console.Write("Kezd új félévet? ");
bool newSemester = Convert.ToBoolean(Console.ReadLine());
first.StartOfSemester(newSemester);
Console.WriteLine(first + "\n");

Console.WriteLine("Repository feladatok:" + "\n");

foreach(var i in strepo.GetAll())
{
    Console.WriteLine(i);
}
Console.WriteLine($"\nTeljesítette a félévet: {strepo.CountIsFinished}");
Console.WriteLine("\nNem teljesítette:");

foreach(var i in strepo.LeftCreditsNameList())
{
    Console.WriteLine($"- {i}");
}


