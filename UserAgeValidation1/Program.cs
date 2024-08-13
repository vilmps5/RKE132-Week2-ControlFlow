// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt tema vanust
//kui vanus on väiksem kui 13, siis kuvatakse: "You are too young to use that program"
//muul juhul kuvatakse "Welcome to program"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); //"13"-heap, 13-stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");


if (isAgeNumber == true) 
{ if (userAgeNum >=13)
    {
        Console.WriteLine("Welcome to Instagram!");       
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }

}
else
{
    Console.WriteLine("Could not verify your age.");
}
