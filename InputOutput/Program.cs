//Declare Variable(data type)
/*
    string - words/numbers, names - "Osman Can"
    int - whole numbers, double/float, decimals - 123
    char - one character - 'A'
 
 
 */

string fullName; //camelCase

//Allow user input and sotre in variable
Console.Write("What's your name?: ");
fullName = Console.ReadLine(); //also we could define var and read at the same time

//Print contents of variable/user's input
Console.WriteLine("Your name is: " + fullName);