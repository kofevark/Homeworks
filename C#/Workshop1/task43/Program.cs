// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Поищем точку пересечения двух прямых. \nПервая из которых задана уравнением y = k1 * x + b1,");
Console.WriteLine("а вторая уравнением y = k2 * x + b2.".PadLeft(52));

// Использовать метод для ввывода сообщения и ввода значения координаты в этом случае бессмысленно, т. к. кода получится гораздо больше
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);

FindIntersection(k1, b1, k2, b2); // Вызываем метод

// Метод для нахождения и вывода в консоль точки пересечения прямых
void FindIntersection(double x1, double y1, double x2, double y2)
{
    if (k1 == k2) { Console.WriteLine("Это параллельные прямые, они не пересекаются"); return; } // Проверка на параллельность
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * (b2 - b1) / (k1 - k2) + b2;
    Console.WriteLine($"Эти прямые пересекаются в точке с координатами ({x}  {y})");
}