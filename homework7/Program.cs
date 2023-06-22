// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
string num = Console.ReadLine() ?? "";
int a = int.Parse(num);
if (a > 99)
{
while (a > 1000)
{
 a = a / 10;
}
Console.WriteLine($"{num} -> {a % 10}");
}
else
{
    Console.WriteLine($"{a}->третьей цифры нет");
}