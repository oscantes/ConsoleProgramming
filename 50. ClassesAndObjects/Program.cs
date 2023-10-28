//primitive/basic datatypes are like varibles but objects are more than that
//object oriented program languages allow us to create our own datatypes and properties of it
//we do this with classes; class = blueprint


//single responsibility principle
//each unit should have only one class responsibility
//meaning if we want to create a Person class, it should have it's own file, should not be in program.cs
//in order to do this, for this project right click to "classesandobjects" and select new item, rename it to Person
//shortcut for this is to select class name and press "ctrl + ." then "move type to" will appear

//after moving Person class to it's own file, how do we interact with it from program.cs?
//we have to do object declaration(not variable this time, variables are primitive datatypes

Person person0 = new(); //".. = new Class_name()" works too

Console.Write("Enter first name: ");
person0.FirstName = Console.ReadLine();

Console.Write("Enter middle name: ");
person0.MiddleName = Console.ReadLine();

Console.Write("Enter last name: ");
person0.LastName = Console.ReadLine();

Console.Write("Enter age: ");
person0.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter salary: ");
double salary = Convert.ToDouble(Console.ReadLine());
person0.setSalary(salary);

if (string.IsNullOrEmpty(person0.MiddleName))
{
    Console.WriteLine("Full name is: " + person0.getFullName());
}
else
{
    //method overload
    Console.WriteLine("Full name is: " + person0.getFullName(person0.MiddleName));
}
Console.WriteLine("Age is: " + person0.Age);
Console.WriteLine("Year of birth is: " + DateUtil.YearOfBirth(person0.Age));
//Console.WriteLine("Year of birth is: " + DateUtil.Age( 2009 - 06 - 15T13: 45:30)); burada DateUtil.Age()'i kullanamadım, hata aldım hep
//person0._salary = Console.ReadLine(); we can't access _salary like this(look at Person class)
Console.WriteLine("Salary is: " + person0.getSalary());