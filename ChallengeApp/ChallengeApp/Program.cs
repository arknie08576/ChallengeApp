
using ChallengeApp;

Employee pracownik1 = new Employee("Tomasz", "Kot", 44);
pracownik1.AddPoints(2);
pracownik1.AddPoints(3);
pracownik1.AddPoints(6);
pracownik1.AddPoints(8);
pracownik1.AddPoints(4);
Employee pracownik2 = new Employee("Maciej", "Cichy", 24);
pracownik2.AddPoints(5);
pracownik2.AddPoints(5);
pracownik2.AddPoints(7);
pracownik2.AddPoints(3);
pracownik2.AddPoints(2);
Employee pracownik3 = new Employee("Paweł", "Typow", 37);
pracownik3.AddPoints(7);
pracownik3.AddPoints(5);
pracownik3.AddPoints(9);
pracownik3.AddPoints(6);
pracownik3.AddPoints(5);

if (pracownik1.Result > pracownik2.Result && pracownik1.Result > pracownik3.Result)
{
    pracownik1.Print();
}
else if (pracownik2.Result > pracownik3.Result)
{
    pracownik2.Print();
}
else
{
    pracownik3.Print();
}