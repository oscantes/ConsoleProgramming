//for loop(counter controlled)
using System;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("I'm in a loop");
}




//while loop(condition controlled, prechecked then done)
int n = 6;
while (n < 5)
{

    Console.Write("Enter a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"You've entered {n}. ");
}
Console.WriteLine("While loop ended");



//do..while loop(condition controlled, postchecked after done)

n = 6;
do
{
    Console.Write("Enter a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"You've entered {n}. ");
} while (n < 5);
Console.WriteLine("do While loop ended");

//foreach usually used with lists, arrays, go through on each one
foreach (var item in args)
{
    
}