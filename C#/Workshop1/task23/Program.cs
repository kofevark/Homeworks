// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (N > 0) // Для положительных чисел
{
    int count = 1;
    Console.WriteLine("Таблица кубов чисел от 1 до N");
    Console.WriteLine(("").PadLeft(29, '-')); // Подчеркнем для красоты
    while (count <= N)
    {
        Console.Write(($"{count}\u00B3").PadLeft(8)); // Подравниваем начальное число и добавляем надстрочный символ 3
        Console.Write(("->").PadLeft(7)); // Выравниваем символ ->
        Console.WriteLine(($"     {Math.Pow(count, 3)}").PadRight(10)); // Возводим в куб и подравниваем результат
        count++;
    }
}
if (N <= 0) // Для нуля и отрицательных чисел
{
    // Для наглядности отойдем от условий задачи и при отрицательных N выведем таблицу кубов от N до 1 (в обратном порядке)
    int count = N;
    Console.WriteLine("Таблица кубов чисел от N до 1");
    Console.WriteLine(("").PadLeft(29, '-')); // Подчеркнем для красоты
    while (count <= 1)
    {
        Console.Write(($"{count}\u00B3").PadLeft(8)); // Подравниваем начальное число и добавляем надстрочный символ 3
        Console.Write(("->").PadLeft(7)); // Выравниваем символ ->
        Console.WriteLine(($"     {Math.Pow(count, 3)}").PadRight(10)); // Возводим в куб и подравниваем результат
        count++;
    }
}