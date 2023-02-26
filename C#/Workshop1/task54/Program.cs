// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
Console.WriteLine("Тот же массив, но с упорядоченными по убыванию строками:");
int[,] orderedArray = OrderingOfRows(array);
PrintArray(orderedArray);

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

// Метод упорядочивания строк по убыванию элементов.
int[,] OrderingOfRows(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++) // Перебираем все строки массива.
    {
        for (int j = 0; j < someArray.GetLength(1); j++) // Перебираем элементы в строке.
        {
            for (int k = j + 1; k < someArray.GetLength(1); k++) // Перебираем оставшиеся элементы.
            {
                if (someArray[i, k] > someArray[i, j]) // Сравниваем элемент с элементом слева.
                {
                    // Устанавливаем самый большой элемент в начало строки.
                    int temp = someArray[i, j];
                    someArray[i, j] = someArray[i, k];
                    someArray[i, k] = temp;
                    temp = 0; // Обнуляем временную переменную.
                }
            }
        }
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
            Console.Write($"{someArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}