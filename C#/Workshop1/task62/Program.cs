// Заполнить спирально массив 4 на 4.

Console.Clear();

// Работа с пользователем.
// ---------------------
// Задание квадратного массива.
Console.Write("Введите размер квадратного массива: ");
int rows = int.Parse(Console.ReadLine()!);
int columns = rows;

// Основной процесс программы.
// ---------------------
int[,] squareArray = FillArray(rows, columns);
PrintArray(squareArray);

// Методы.
// ---------------------
// Метод спирального заполнения массива 
int[,] FillArray(int someRows, int someColumns)
{
    int[,] someArray = new int[someRows, someColumns];
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= someArray.GetLength(0) * someArray.GetLength(1))
    {
        someArray[i, j] = value;
        value++;
        if (i <= j + 1 & i + j < someArray.GetLength(1) - 1)
            j++;
        else if (i < j & i + j >= someArray.GetLength(0) - 1)
            i++;
        else if (i >= j & i + j > someArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return someArray;
}

// Метод печати двумерного массива.
void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]}  ".PadLeft(4));
        }
        Console.WriteLine();
    }
}