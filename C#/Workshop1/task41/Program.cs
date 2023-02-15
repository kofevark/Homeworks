// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Write("Введите числа через пробел и нажмите Ввод: "); // Вводим числа. Можно не целые, но с запятой
string input = Console.ReadLine()!; // Переводим введенное в строку
string[] subs = input.Split(); // Создаем из строки строковый массив
double[] array = new double[subs.Length]; // Глобально объявляем double массив с длиной, равной количеству введенных чисел
ConvertStringToDouble(subs); // Ковертируем строковый массив в double
PrintDoubleArray(array); // Печатаем массив на всякий случай
Console.WriteLine($" -> {FindPositiveNums(array)}"); // Показываем, сколько из введенных пользователем чисел положительны

// Метод преобразования массива string в double
double[] ConvertStringToDouble(string[] someArray)
{
    for (int i = 0; i < subs.Length; i++) array[i] = Double.Parse(subs[i]); // Конвертируем строку в число с запятой. При вводе необходимо вводить числа через запятую (при необходимости), а не через точку
    return array;
}

// Метод поиска положительных значений
int FindPositiveNums(double[] someArray)
{
    int counter = 0;
    foreach (double element in array) if (element > 0) counter++; // Пробегаем по всем значениям в массиве
    return counter;
}

//Метод печати массива типа double
void PrintDoubleArray(double[] someArray)
{
    // Выводим в виде [1, 2, 3, 4]
    Console.Write("[");
    for (int i = 0; i < someArray.Length - 1; i++) Console.Write($"{someArray[i]}, ");
    Console.Write($"{someArray[someArray.Length - 1]}]");
}