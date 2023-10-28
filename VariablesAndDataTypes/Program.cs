//Variable declerations and types
string fullName = string.Empty;
int age;
double salary = 0;
char gender = char.MinValue;
bool working;

Console.Write("Enter your name: ");
fullName = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your gender('M' or 'F'): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? Answer with 'True' or 'False' please: ");
working = Convert.ToBoolean(Console.ReadLine());

//Print information back to the user
Console.WriteLine("Your name is " + fullName); //concatenation
Console.WriteLine("Your age is {0} and your salary is {1}", age, salary); //arguments
Console.WriteLine($"Your gender is {gender}"); //interpolation
Console.WriteLine($"You are employed: {working}"); //interpolation