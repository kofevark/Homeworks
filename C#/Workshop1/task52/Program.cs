// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

// Размер массива пусть задаст пользователь.
// ---------------------
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------
int[,] array = GetArray(rows, columns);
PrintBigArray(array);
double[] averageArray = FindAverageOfColumns(array);
PrintSmallArray(averageArray);

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

// Ищем среднее арифметическое элементов в каждом столбце.
double[] FindAverageOfColumns(int[,] someArray)
{
    double[] average = new double[someArray.GetLength(1)];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            average[j] += someArray[i, j]; // Складываем элементы в столбцах.
        }
    }
    for (int i = 0; i < average.Length; i++)
    {
        // Делим получившиеся суммы на количество строк и округляем до десятых
        average[i] = Math.Round(average[i] / rows, 1);
    }
    return average;
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

// Печатаем одномерный массив типа double.
void PrintSmallArray(double[] someArray)
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце этого массива:");
    for (int i = 0; i < someArray.Length; i++)
    {
        // Пытаемся хоть немного расставить результат в соответствии с начальным массивом.
        Console.Write($" {someArray[i]}".PadRight(5));
    }
    Console.WriteLine();
}