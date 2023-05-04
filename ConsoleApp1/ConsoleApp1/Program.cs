string name = "Ewa";
bool isWoman = true;
int age = 33;
int age2 = 16;


if (isWoman == true && age2 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (isWoman == false && age2 < 30)
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else
{
    Console.WriteLine("Osoba w wieku 30 lat lub starsza");
}

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

if (isWoman == false && age2 < 18)
{
    Console.WriteLine("Niepełnoletnia kobieta");
}
else if (isWoman == true && age2 < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Osoba pełnoletnia");
}