
int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

Console.WriteLine("Wyniki dla liczby: " + number);

for (int i = 0; i < 10; i++)
{
    int numberOfAppereances = 0;

    foreach (char c in letters)
    {
        if (i.ToString() == c.ToString())
        {
            numberOfAppereances++;
        }

    }

    Console.WriteLine(i + " => " + numberOfAppereances);



}