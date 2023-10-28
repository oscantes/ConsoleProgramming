//exception handling is done with try catch block

/*
try - a try block attemps and operation
catch - catch any fatal error or exception
throw - end program execution with the error
finally - whether the try or catch was succesful, do this
*/

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    int quotient = num1 / num2;
    Console.WriteLine($"Result is {quotient.ToString()}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Sıfıra bölemen guzum. ({ex.Message})");
}
catch (Exception ex) //catch exception and store it in exp var
{
    throw ex; //kills program
}
finally
{
    Console.WriteLine("This is the end of the program.");
}