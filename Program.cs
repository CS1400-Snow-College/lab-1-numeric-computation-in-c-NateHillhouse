using System.Runtime.InteropServices;
int a = 5;
int b = 6;
int c = 7;
//Math in an expression using variables
Console.WriteLine($"{a} + {b} = {a + b}");

//Using multiple operations and storing them within a variable
int d = a * b-c ;
Console.WriteLine($"{a} * {b} - {c} = {d}");

//Playing with the Remainder function
Console.WriteLine($"Remainder: {a} % {b} = {a % b}");

//Playing with Mins and Maxs
List<int> range = [1, 2, 3, 4];
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"Ints goes from {max} to {min}");

//Overflow example
Console.WriteLine($"Overflow: {max + 3}");


//Doubles and Decimals
double x = 1.0;
double y = 3.0;
decimal z = 1.0M;
decimal w = 3.0M;
Console.WriteLine($"Int: 1 / 3 = {1 / 3}");
Console.WriteLine($"Double: {x} / {y} = {x / y}");
Console.WriteLine($"Decimal: {z} / {w} = {z / w}");
//Decimals are more accurate

