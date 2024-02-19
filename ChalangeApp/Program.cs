string name = "Ewa";
var age = 30;
string sex = "man";

if(age < 30 && sex =! "man")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if( age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 30");
}
else if(age < 18 && sex == "man")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}