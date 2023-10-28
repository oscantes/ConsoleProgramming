//basic assignment operator
int num = 5;




//arithmetic operators
int num1;
int num2;

Console.Write("Toplanacak 2 değerden ilkini girin: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Toplanacak 2 değerden ikincisini girin: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Değerler toplamı: {num1 + num2}");
Console.WriteLine($"Değerler farkı: {num1 - num2}");
Console.WriteLine($"Değerler çarpımı: {num1 * num2}");
Console.WriteLine($"Değerler bölümü(whole): {num1 / num2}");
Console.WriteLine($"Mod(remainder): {num1 % num2}");



//compund assigment operators


num1 += 4; // = num1 = num1 + 4;
num1 /= 4; // = num1 = num1 + 4;
num1 %= 4; // = num1 = num1 + 4;
//..
Console.WriteLine($"Latest num1 value is: {num1}");