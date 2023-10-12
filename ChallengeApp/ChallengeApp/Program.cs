
using ChallengeApp;

Console.WriteLine("Witaj w programie do oceny pracowników");

var employee = new Employee("Jan","Taki",33);


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika w zakresie literowym a/A - f/F lub zakresie liczbowym 0 - 100");
    Console.WriteLine("wpisz q jeśli chcesz zakończyć dodawanie ocen");

    var ocena = Console.ReadLine();
    
    if (ocena == "q")
    {

        break;
    }
    
    
    employee.AddPoints(ocena);

}

employee.Print();