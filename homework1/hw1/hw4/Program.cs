// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

int N = new Random().Next(1,  111);
Console.Write("Интервал от 1 до  ");
Console.WriteLine(N);
Console.Write("Четные числа:  ");
int a = 1;
while (a<=N)
{
    if (a % 2 ==0)
    {
        Console.WriteLine(a);
    }
    a = a + 1;
}