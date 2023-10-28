//methods & functions represent the same construct

//prototype - defines the function(type, name and parameters)
//definition - has the code, it contains the code block
//function call - makes the function

//DRY - don't repeat yourself, write a function and call it instead of writing code over and over
//YAGNI - you aren't going to need it, don't write code that you don't need

//Console.WriteLine() this function is void, doesn't return anything
//Console.ReadLine() but this one returns a value, a string


//void functions, completes a task and moves along
void PrintName()
{
    Console.WriteLine("PrintName func called");
}

PrintName();



Console.Write("Toplama işlemi yapılacak, 1. sayıyı girin: ");
int num1 = Convert.ToInt32(Console.ReadLine()); //üstteki num1 tanım scope'u burayı kapsamadığından kullanılabilir, karışmaz

Console.Write("2. sayıyı girin: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Addition(int num1, int num2)
{
    Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
}

Addition(num1, num2);



//value returning of functions, completes a task and returns a result

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if (num1 < num2)
    {
        largest = num2;
    }
    if (largest < num3)
    {
        largest = num3;        
    }
    return largest; //method içerisinde bir şey yoksa hata veriyor çünkü void olmadığı için bir şey döndürmeli
}

Console.Write("3 sayı içerisinden en büyüğü bulunacak, 1. sayıyı girin: ");
int num11 = Convert.ToInt32(Console.ReadLine()); //üstteki num1 tanım scope'u burayı kapsamadığından kullanılabilir, karışmaz

Console.Write("2. sayıyı girin: ");
int num12 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. sayıyı girin: ");
int num13 = Convert.ToInt32(Console.ReadLine());

//int result = LargestNumber(num11, num12, num13);
//Console.WriteLine($"Largest number is {result}");
Console.WriteLine($"Largest number is {LargestNumber(num11, num12, num13)}");