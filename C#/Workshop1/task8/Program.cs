// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите любое число, отличающееся от 1: ");
int N = int.Parse(Console.ReadLine()!);
if (N != 1) Console.WriteLine("Вот вам все четные числа от 1 до введенного:");
int count = 1;
if (N > 1)
{
    while (count <= N)
    {
        if (count % 2 == 0) Console.Write(count + ", ");
        count++;
    }
}
if (N < 1)
{
    while (count >= N)
    {
        if (count % 2 == 0) Console.Write(count + ", ");
        count--;
    }
}
if (N == 1) Console.WriteLine("Говорил же не вводить 1...");