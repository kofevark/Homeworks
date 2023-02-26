// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

// Работа с пользователем.
// ---------------------
// Задание размера массива.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------
int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine();
FindSmallRow(array);

// Методы.
// ---------------------
// Метод заполнения массива от 0 до 9.
int[,] FillArray(int someRows, int someColumns)
{
    // Увеличим массив на один столбец, будем класть туда сумму элементов в строке.
    int[,] someArray = new int[someRows, someColumns + 1];
    int sum = 0;
    for (int i = 0; i < someRows; i++)
    {
        // Генерируем числа от 0 до 9 и заполняем массив за исключением полседнего столбца.
        for (int j = 0; j < someColumns; j++)
        {
            someArray[i, j] = new Random().Next(0, 10);
            sum = sum + someArray[i, j];
        }
        someArray[i, someColumns] = sum; // Запишем в последний столбик сумму элементов.
        sum = 0; // Обнуляем sum для следующей строки.
    }
    return someArray;
}

// Метод поиска строки с наименьшей суммой элементов.
void FindSmallRow(int[,] someArray)
{
    int minSum = someArray[0, someArray.GetLength(1) - 1]; // Временная переменная для поиска строки с минимумом.
    int indexOfMinRow = 0; // Индекс строки с наименьшей суммой.
    for (int i = 1; i < someArray.GetLength(0); i++)
    {
        if (someArray[i, someArray.GetLength(1) - 1] < minSum)
        {
            minSum = someArray[i, someArray.GetLength(1) - 1];
            indexOfMinRow = i;
        }
    }
    Console.WriteLine($"Строка с индексом [{indexOfMinRow}] имеет наименьшую сумму элементов:");
    for (int j = 0; j < someArray.GetLength(1) - 1; j++)
        Console.Write($"{someArray[indexOfMinRow, j]}  ");
    Console.WriteLine();
}

// Метод печати двумерного массива.
void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1) - 1; j++)
        {
            Console.Write($"{someArray[i, j]}  ");
        }
        Console.WriteLine($"({someArray[i, someArray.GetLength(1) - 1]})");
    }
}