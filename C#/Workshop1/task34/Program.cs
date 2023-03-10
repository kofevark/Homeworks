// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine()!); // Инициализировали размер массива и присвоили ему число
int[] array = new int[size]; // Объявили массив заданного размера
int counter = 0; // Переменная для подсчета четных чисел

array = GetArray(size); // Вызвали метод для наполнения массива
PrintArray(array); // Напечатали массив
Console.WriteLine($"Количество четных чисел в массиве - {counter}"); // Выводим счетчик четных чисел

int[] GetArray(int i) // Метод наполнения массива. Почему-то тут не срабатывает фишка объявления переменной прям при объявлении метода. Точнее объявляется переменная, но ноль ей не присваивается. Присваивается сразу занчение размера. Поэтому пришлось переопределять ее в цикле.
{
    for (i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000); // Заполняем массив трехзначными числами
        if (array[i] % 2 == 0) counter++; // Подсчитываем четные числа
    }
    return array;
}

void PrintArray(int[] array) // Метод для печати массива
{
    // Извращаемся, чтобы массив был окружен квадратными скобками и запятая после последнего числа не ставилась
    Console.Write("[");
    for (int j = 0; j < size - 1; j++) Console.Write($"{array[j]}, ");
    Console.WriteLine($"{array[size - 1]}]");
}