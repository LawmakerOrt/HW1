//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter number");
string nume1 = Console.ReadLine();
int num1 = int.Parse(nume1);

Console.WriteLine("Enter second number");
string nume2 = Console.ReadLine();
int num2 = int.Parse(nume2);

if (num1 > num2)
{
    Console.WriteLine($"max number {num1}");
}
else
{
    Console.WriteLine($"max number {num2}");
}