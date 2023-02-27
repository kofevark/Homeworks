// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

// Работа с пользователем.
// ---------------------
Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------
Console.Write($"M = {numberM}; N = {numberN} -> ");

// Проверка и переопределение переменных при необходимости.
int temp = 0;
if (numberM > numberN)
{
    temp = numberM;
    numberM = numberN;
    numberN = temp;
}

int sum = 0;
sum = FindSumBetweenNumbers(numberM, numberN);
Console.WriteLine(sum);

// Методы.
// ---------------------
// Рекурсивный метод нахождения суммы чисел в промежутке от M до N.
int FindSumBetweenNumbers(int m, int n)
{
    if (n >= m)
    {
        sum += n;
        FindSumBetweenNumbers(m, n - 1);
    }
    return sum;
}