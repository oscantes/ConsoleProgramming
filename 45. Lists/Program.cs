//declare
List<string> names = new List<string>();

//add values to list
names.Add("Osman Can");
names.Add("Trevoir");

string name = string.Empty;

//while (name != "-1")
//while (name.Equals("-1") == false)
while (!name.Equals("-1")) //we use -1 to exit the program because normally this is not a value that we enter willingly
{
    Console.Write("Enter name: ");
    name = Console.ReadLine();
    if ( !string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was added succesfully");
    }
}

Console.WriteLine("Girilen isimler aşağıdaki gibidir(with for loop); ");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Girilen isimler aşağıdaki gibidir(with foreach loop); ");
foreach (string item in names)
{
    Console.WriteLine(item);
}