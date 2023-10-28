Console.Write("Enter number of Apples: ");
int numOfApples = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of oranges: ");
int numOfOranges = Convert.ToInt32(Console.ReadLine());


//if statements ( ==(equivalent), <, >, >=, <=, != )
if (numOfApples > numOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numOfApples < numOfOranges)
{
    Console.WriteLine("You have more oranges");
}
else if (numOfApples == numOfOranges)
{
    Console.WriteLine("You have the same number or apples and oranges");
}
else
{
    Console.WriteLine("no direct action");
}


//switch statements
Console.Write("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch (grade) //if more than one is true, output will be the first one
{
    case 0:
        Console.WriteLine("you failed hard");
        break;
    case int n when n > 0 && n <= 40:
        Console.WriteLine("you failed soft");
        break;
    case 10:
        Console.WriteLine("you got 10");
        break;
    case int n when n > 40 && n < 100:
        Console.WriteLine("you got good grade");
        break;
    case int n when n == 100:
        Console.WriteLine("enormous");
        break;
    default:
        Console.WriteLine("invalid grade");
        break;
}

//ternary operators
var massage = numOfApples > numOfOranges ? "you have more apples" : "you have more oranges";
Console.WriteLine(massage);