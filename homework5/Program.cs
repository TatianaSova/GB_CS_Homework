Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);

if (a%2==0)
{
    Console.WriteLine ($"a={a%2} -> да");
}
else
{
    Console.WriteLine ($"a={a%2} -> нет");
}