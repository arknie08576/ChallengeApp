
using ChallengeApp;
using System.Xml.Linq;

Console.WriteLine("Witaj w programie do oceny pracowników");

var employee = new Employee("Jan", "Taki", 33);


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika w zakresie literowym a/A - f/F lub zakresie liczbowym 0 - 100");
    Console.WriteLine("wpisz q jeśli chcesz zakończyć dodawanie ocen");

    var ocena = Console.ReadLine();

    if (ocena == "q")
    {

        break;
    }

    try
    {
        employee.AddPoints(ocena);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);

    }
}


Console.WriteLine(employee.Name + " " + employee.Surname + ", wiek " + employee.Age);
Console.WriteLine("Min ocena: " + employee.GetStatistics().Min);
Console.WriteLine("Max ocena: " + employee.GetStatistics().Max);
Console.WriteLine("Przeciętna ocena: " + employee.GetStatistics().Average + " czyli literowo " + employee.GetStatistics().AverageLetter);