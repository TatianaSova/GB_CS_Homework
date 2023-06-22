// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите х для точки А: ");
double dotAx = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите y для точки А: ");
double dotAy = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите z для точки А: ");
double dotAz = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите х для точки В: ");
double dotBx = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите y для точки В: ");
double dotBy = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите z для точки В: ");
double dotBz = double.Parse(Console.ReadLine() ?? "");

double distance = Math.Sqrt((dotBx - dotAx)*(dotBx - dotAx) + (dotBy - dotAy)*(dotBy - dotAy) + (dotBz - dotAz)*(dotBz - dotAz));

Console.WriteLine($"расстояние между двмя точками рано {distance:f2}");