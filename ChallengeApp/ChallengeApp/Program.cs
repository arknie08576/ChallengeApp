
using ChallengeApp;

Employee worker1 = new Employee("Tomasz", "Kot", 44);
worker1.AddPoints(2);
worker1.AddPoints(3);
worker1.AddPoints(6);
worker1.AddPoints(8);
worker1.AddPoints(4);
Employee worker2 = new Employee("Maciej", "Cichy", 24);
worker2.AddPoints(5);
worker2.AddPoints(5);
worker2.AddPoints(7);
worker2.AddPoints(3);
worker2.AddPoints(2);
Employee worker3 = new Employee("Paweł", "Typow", 37);
worker3.AddPoints(7);
worker3.AddPoints(5);
worker3.AddPoints(9);
worker3.AddPoints(6);
worker3.AddPoints(5);

if (worker1.GetStatistics().Average > worker2.GetStatistics().Average && worker1.GetStatistics().Average > worker3.GetStatistics().Average)
{
    worker1.Print();
}
else if (worker2.GetStatistics().Average > worker3.GetStatistics().Average)
{
    worker2.Print();
}
else
{
    worker3.Print();
}