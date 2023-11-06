using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.FileIO;

string name = "Ewa";
var sex = "male";
int age = 15;

if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepełonoletni mężczyzna");
}

