//in this class, there will be properties of person

//regular classes
//public class - accessible to the world
//internal class - accessible to files in the same project only(here ClassesAndObjects)
//private class - less used, for example you can't have private class if that class has public properties

//static class
//You can't create an instance of this, for example Console class, we don't say Console konsol = new()..
//Can be used like Console.xxx, others for example Person class(regular class) can't be used like Person.xxx
//Properties of Person(regular class) is not accessible without instantiating it, unlike static classes
//if a class is static, methods inside of that class have to be static, too

public class Person
{
    //get sets are called accessors
    //when used like {get; set; } the one who interacts with that property has the leverage of both getting and setting value of that property
    //for example if FirstName was {get; } only, we couldn't change Age property of a Person object(like person0 in program.cs)

    //when public we call these properties
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    //when private we call these fields
    private double _salary {  get; set; }

    //because this is private, we need methods to interact with _salary field and they should be public

    public void setSalary(double d) //it's void because we don't need to return anything
    {
        _salary = d;
    }

    public double getSalary() //because we have to run this method to retrieve _salary value, it can't be void
    {
        return _salary;
    }
    //extra
    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }
    //method overload
    public string getFullName(string m)
    {
        return $"{FirstName} {m} {LastName}";
    }
}