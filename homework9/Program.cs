//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ?? "");
int a = 0, num = number;
while (number > 0) {a = a * 10 + number % 10; number /= 10;}
if (num == a)
{
 Console.WriteLine($"да");
}
else
{
 Console.WriteLine($"нет");
}