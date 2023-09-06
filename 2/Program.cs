//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Enter number");
string nume1 = Console.ReadLine();
int num1 = int.Parse(nume1);

Console.WriteLine("Enter second number");
string nume2 = Console.ReadLine();
int num2 = int.Parse(nume2);

Console.WriteLine("Enter third number");
string nume3 = Console.ReadLine();
int num3 = int.Parse(nume3);

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

System.Console.WriteLine($"max = {max}");
