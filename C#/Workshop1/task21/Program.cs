// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату X для точки А: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y для точки А: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z для точки А: ");
int Az = int.Parse(Console.ReadLine());
Console.Write("Введите координату X для точки B: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y для точки B: ");
int By = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z для точки B: ");
int Bz = int.Parse(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));
Console.WriteLine($"Расстояние между точками A и B равно {S}");