// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine()!); // Инициализировали размер массива и присвоили ему число
double[] array = new double[size]; // Объявили массив заданного размера
double minValue = 100; // Задал значения для min и max по самым краям диапазона, чтобы генерируемые числа точно были меньше min и больше max
double maxValue = -100;
double result = 0;

array = GetArray(size);
PrintArray(array);
DiffMaxMin(array);

Console.WriteLine(("").PadLeft(10, '-')); // Подчеркнем для красоты
Console.WriteLine($"Минимальное число в массиве: {minValue}");
Console.WriteLine($"Максимальное число в массиве: {maxValue}");
Console.WriteLine($"Разнница между максимальным и минимальным числами в массиве: {result}");

double[] GetArray(double x) // Метод наполнения массива. Почему-то тут не срабатывает фишка объявления переменной прям при объявлении метода. Точнее, объявляется переменная, но ноль ей не присваивается. Присваивается сразу занчение размера. Поэтому пришлось переопределять ее в цикле.
{
    for (int i = 0; i < size; i++) array[i] = new Random().NextDouble() * 200 - 100; // Заполняем массив двузначными числами
    return array;
}

void PrintArray(double[] arr) // Метод для печати массива
{
    Console.WriteLine("Наш массив:");
    for (int j = 0; j < size; j++) Console.WriteLine(($"{Math.Round(array[j], 5)}").PadLeft(10));
    // Округляем значения массива до 5 знаков после запятой и подравняем по правому краю
}

double DiffMaxMin(double[] y) // Метод поиска min и max разницы между ними
{
    foreach (double i in array)
    {
        if (i < minValue) minValue = Math.Round(i, 5); // Для наглядности округляем все переменные до 5 знаков после запятой
        if (i > maxValue) maxValue = Math.Round(i, 5);
    }
    return result = Math.Round(Math.Abs(maxValue - minValue), 5); // Разницу взяли по модулю и округлили до 5 знаков после запятой
}