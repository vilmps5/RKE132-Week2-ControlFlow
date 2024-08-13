// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt tema sugu (m/f)
//rakendus küsib kasutaja Perekonnanime
//rakendus tervitab kasutajat: "Welcome, Mr. [kasutaje perekonnanimi]2/ "Welcome, Ms. [kasutaje perekonnanimi]"


Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your lastname:");

string userLastName = Console.ReadLine();

if(userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f') 
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else 
{
    Console.WriteLine($"Welcome {userLastName}!");   
}
