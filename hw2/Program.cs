﻿// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих трех

int a = new Random().Next(1,  10);
Console.WriteLine(a);
int b = new Random().Next(1,  10);
Console.WriteLine(b);
int c = new Random().Next(1,  10);
Console.WriteLine(c);

int max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("max  ");
Console.WriteLine(max);
