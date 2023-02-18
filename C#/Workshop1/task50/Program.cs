// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();

// Работа с пользователем
Console.WriteLine("Есть у нас один массив. Поищем элемент в нем?");
Console.Write("Введите номер строки элемента в массиве: ");
int firstIndex = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца элемента в массиве: ");
int secondIndex = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------
int[,] array = GetArray(5, 5); // Массив создали фиксированный, 5 на 5
Console.WriteLine("Вот наш массив:");
Console.WriteLine("--------------");
PrintBigArray(array);
FindElement(array);

// Методы.
// ---------------------
// Заполняем случайными целыми числами от 0 до 9 наш двумерный массив.
int[,] GetArray(int someRows, int someColumns)
{
    int[,] someArray = new int[someRows, someColumns];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            someArray[i, j] = new Random().Next(0, 10);
        }
    }
    return someArray;
}

// Печатаем двумерный массив.
void PrintBigArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            // Пробелами немного сдвинем и расширим массив для наглядности.
            Console.Write($" {someArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}

// Поиск указанного элемента.
void FindElement(int[,] someArray)
{
    // Проверка, что введенный индекс находится не за пределами массива.
    if (firstIndex < 0 || firstIndex >= someArray.GetLength(0) || secondIndex < 0 || secondIndex >= someArray.GetLength(1))
    {
        Console.WriteLine($"Такой позиции [{firstIndex}, {secondIndex}] не существует в этом массиве.");
        return;
    }
    else Console.WriteLine($"На этой позиции [{firstIndex}, {secondIndex}] стоит вот этот элемент {someArray[firstIndex, secondIndex]}.");
}