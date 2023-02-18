// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

// Размер массива пусть задаст пользователь.
// ---------------------
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------
double[,] array = GetArray(rows, columns);
PrintArray(array);

// Методы.
// ---------------------
//Наполняем массив типа double
double[,] GetArray(int someRows, int someColumns)
{
    double[,] someArray = new double[someRows, someColumns];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            // Заполняем случайными вещественными числами от -10 до 10 и коругяем до десятых.
            someArray[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        }
    }
    return someArray;
}

// Печатаем наш массив.
void PrintArray(double[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            // Немного подравняем и расширим массив для наглядности.
            Console.Write($"{someArray[i, j]}".PadLeft(8));
        }
        Console.WriteLine();
    }
}