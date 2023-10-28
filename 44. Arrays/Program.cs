//arrays is collection of values

using System.ComponentModel;

int[] grades = new int[5]; //5 spaces address will be reserved in memory
//if n is the size of the array, then your array has addresses between 0 to n-1

//add values to fixed size array
grades[0] = 1;
grades[1] = 33;
grades[4] = 44;

//prompt user to enter value
for (int i = 0; i < grades.Length; i++) //array'in fixed size olması önemli
{
    Console.Write($"{i + 1}. öğrencinin notunu girin: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

//print values in fixed size array
Console.WriteLine("Girilen notlar: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i] + " ");
}

//declare variable sized array
int[] bananas = { 1, 2, 3 };
for (int i = 0; i < bananas.Length; i++)
{
    Console.WriteLine("banana değerleri: " + bananas[i]);
}

//another way to assign values to an variable sized array
string[] studentNames;
studentNames = new string[] {"Ali", "Veli", "Ahmet", "Mehmet"};
Console.WriteLine("Student names are: ");
for(int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}
