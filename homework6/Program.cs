﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Использовала рандом

Console.Clear();
int num = new Random() .Next (100,999);
int a = (num/10) % 10;

Console.WriteLine($"Вторая цифра в числе {num} -> {a}");