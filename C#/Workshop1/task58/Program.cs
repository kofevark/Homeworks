// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

// Работа с пользователем.
// ---------------------
// Задание размера массива.
Console.WriteLine("Умножим две матрицы. \nКоличество столбцов в первой должно быть равно количеству строк во второй.");
Console.Write("Введите количество строк матрицы А: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы A: ");
int columnsA = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк матрицы B: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов матрицы B: ");
int columnsB = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------

// Проверка возможности перемножения.
if (columnsA != rowsB || columnsB != rowsA)
{
    Console.WriteLine("Эти матрицы нальзя перемножить.");
    return;
}

int[,] matrixA = FillArray(rowsA, columnsA);
PrintArray(matrixA);
Console.WriteLine();
int[,] matrixB = FillArray(rowsB, columnsB);
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Результат перемножения матрицы А и матрицы В:");
int[,] matrixMulti = MultiplicationMatrix(matrixA, matrixB);
PrintArray(matrixMulti);

// Методы.
// ---------------------
// Метод заполнения массива от 0 до 9.
int[,] FillArray(int someRows, int someColumns)
{
    int[,] someArray = new int[someRows, someColumns];
    for (int i = 0; i < someRows; i++)
    {
        for (int j = 0; j < someColumns; j++)
        {
            someArray[i, j] = new Random().Next(0, 10);
        }
    }
    return someArray;
}

// Метод перемножения матриц.
int[,] MultiplicationMatrix(int[,] someArrayA, int[,] someArrayB)
{
    int[,] multiArray = new int[someArrayA.GetLength(0), someArrayB.GetLength(1)];
    for (int i = 0; i < someArrayA.GetLength(0); i++)
    {
        for (int j = 0; j < someArrayB.GetLength(1); j++)
        {
            for (int k = 0; k < someArrayA.GetLength(1); k++)
            {
                multiArray[i, j] += someArrayA[i, k] * someArrayB[k, j];
            }
        }
    }
    return multiArray;
}

// Метод печати двумерного массива.
void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]}  ".PadLeft(5));
        }
        Console.WriteLine();
    }
}