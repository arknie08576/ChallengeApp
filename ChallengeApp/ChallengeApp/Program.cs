
using ChallengeApp;
using System.Xml.Linq;

Console.WriteLine("Witaj w programie do oceny pracowników");

var employee = new EmployeeInFile("Jan", "Taki", 33, 'M');
employee.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs e)
{
    Console.WriteLine("Dodano nową ocenę");

}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika w zakresie literowym a/A - e/E lub zakresie liczbowym 0 - 100");
    Console.WriteLine("wpisz q jeśli chcesz zakończyć dodawanie ocen");

    var ocena = Console.ReadLine();

    if (ocena == "e" ||ocena =="E")
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
//bug fix

Console.WriteLine(employee.Name + " " + employee.Surname + ", wiek " + employee.Age);
Console.WriteLine("Min ocena: " + employee.GetStatistics().Min);
Console.WriteLine("Max ocena: " + employee.GetStatistics().Max);
Console.WriteLine("Przeciętna ocena: " + employee.GetStatistics().Average + " czyli literowo " + employee.GetStatistics().AverageLetter);