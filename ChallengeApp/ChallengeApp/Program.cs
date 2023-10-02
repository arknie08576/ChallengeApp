// See https://aka.ms/new-console-template for more information


string name = "Ewa";
int age = 33;
bool isWoman = true;

if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");

}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");

}
else if (age < 18 && isWoman == false)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}


