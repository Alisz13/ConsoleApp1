string name = "Ewa";
string gender = "kobieta";
string gender2 = "mężczyzna";
int age = 17;
int age2 = 33;



if (gender == "kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta w wieku 30 lat lub starsza");
    }
}


if (name == "Ewa" && age2 == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("To nie jest Ewa, lat 33");
}

if (gender2 == "mężczyzna")
{
    if (age > 18)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
}