//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter number");
string nume1 = Console.ReadLine();
int num1 = int.Parse(nume1);

if (num1 % 2 == 0)
{
    Console.WriteLine("Чет");
}
else
{
    Console.WriteLine("Нечет");
}