// Напишите программу,которая на вход принимает число и выдает, является ли число четным

int a = new Random().Next(1,    10);
if (a%2 == 0)
{
    Console.Write(a);
    Console.WriteLine("  -  четное число");
}
else
{
    Console.Write(a);
    Console.WriteLine("  -  нечетное число");
}

