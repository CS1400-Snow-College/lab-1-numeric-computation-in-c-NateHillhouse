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
Console.WriteLine($"Int goes from {max} to {min}");

//Overflow example
Console.WriteLine($"Overflow: {max + 3}");

