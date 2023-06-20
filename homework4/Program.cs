Console.Clear();
Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);
 Console.Write("Введите третье число: ");
string userInput2 = Console.ReadLine() ?? "";
int с = int.Parse(userInput3);

if (a==с)
{
 Console.WriteLine($"a={a}, b={b}, c={c} -> no");
}
else
{
 Console.WriteLine($"a={a}, b={b}? c={c}  -> max={c}");
}
