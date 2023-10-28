string firstName = "Osman Can";
string lastName = "Telci";
DateTime date = DateTime.Now;

//print to screen

Console.WriteLine("My name is " + firstName);
Console.WriteLine($"My full name is {firstName} {lastName}");

//string length
int length = firstName.Length;
Console.WriteLine("My name is {0} letters long", length);


//replace string parts
string newName = firstName.Replace('O', 'Ö');
Console.WriteLine($"My new name is {newName}");

//append to other string variable
string entryLine = "username;template;notes;status description";

//split string
string[] split_entryLine= entryLine.Split(";");
for (int i = 0; i < split_entryLine.Length; i++)
{
    Console.WriteLine(split_entryLine[i]);    
}


//compare strings
string nullString = null;
string emptyString = ""; //string.Empty
string whitespaceString = " ";

if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("nullString is null");

}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

//convert to String
string convertedString = string.Empty;
int number = 123144412;
convertedString = number.ToString();
convertedString = 2342342.ToString();


//code example for cspl
string[] entryLinee = { "username", "template", "note", "status description" };
string entryLineetoFile = string.Join(';', entryLinee);
Console.WriteLine(entryLineetoFile);