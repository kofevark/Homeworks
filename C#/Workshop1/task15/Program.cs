// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.Write("Поздравляю, сегодня");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" выходной!");
}
if (day > 0 & day < 6) Console.WriteLine("Это рабочий день, но выходные уже скоро ...");
if (day < 1 || day > 7) Console.WriteLine("В неделе СЕМЬ дней!");