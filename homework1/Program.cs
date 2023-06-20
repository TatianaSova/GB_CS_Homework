Console.Clear();
Console.Write("Введите длину: ");
string a = Console.ReadLine() ?? "";
int N = int.Parse(a);
    
for (int i = 1; i <= N; i++)
if (i%2 == 0)
{
     Console.WriteLine($"{i}");
}