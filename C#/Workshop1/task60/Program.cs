// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

// Работа с пользователем.
// ---------------------
// Задание размера массива.
Console.WriteLine("Создадим трехмерный массив");
Console.Write("Введите размер массива по оси X: ");
int axisX = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер массива по оси Y: ");
int axisY = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер массива по оси Z: ");
int axisZ = int.Parse(Console.ReadLine()!);

// Основной процесс программы.
// ---------------------
int[,,] array3D = FillArray3D(axisX, axisY, axisZ);
PrintArray3D(array3D);

// Методы.
// ---------------------
// Метод заполнения трехмерного массива.
int[,,] FillArray3D(int someX, int someY, int someZ)
{
    // Проверка на неповторяемость чисел в массиве.
    int[] tempArray1D = new int[someX * someY * someZ];
    int number;
    for (int i = 0; i < tempArray1D.GetLength(0); i++)
    {
        tempArray1D[i] = new Random().Next(10, 100);
        number = tempArray1D[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray1D[i] == tempArray1D[j])
                {
                    tempArray1D[i] = new Random().Next(10, 100);
                    j = 0;
                    number = tempArray1D[i];
                }
                number = tempArray1D[i];
            }
        }
    }
    // Создание и наполнение трехмерного массива.
    int[,,] someArray3D = new int[someX, someY, someZ];
    int l = 0;
    for (int i = 0; i < someArray3D.GetLength(0); i++)
    {
        for (int j = 0; j < someArray3D.GetLength(1); j++)
        {
            for (int k = 0; k < someArray3D.GetLength(2); k++)
            {
                someArray3D[i, j, k] = tempArray1D[l];
                l++;
            }
        }
    }
    return someArray3D;
}

// Метод печати трехмерного массива.
void PrintArray3D(int[,,] someArray3D)
{
    for (int i = 0; i < someArray3D.GetLength(0); i++)
    {
        for (int j = 0; j < someArray3D.GetLength(1); j++)
        {
            for (int k = 0; k < someArray3D.GetLength(2); k++)
            {
                Console.WriteLine($"[{i},{j},{k}] -> {someArray3D[i, j, k]}");
            }
        }
    }
}