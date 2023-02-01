// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Поищем третью цифру в разных числах:");
int range = 1000000;
int count = 1;
while (count <= 6) // Для примера шесть случайных чисел
{
    int number = new Random().Next(-range, range); // Любое целое из диапазона (-1 000 000, 999 999)
    Console.Write($"{number} -> ");
    string str = number.ToString(); // Для поиска третьей цифры переведем число в строку
    if (number > -100 & number < 100) // Проверка, что цифр в числе больше двух
    {
        Console.Write("У этого числа ");
        Console.ForegroundColor = ConsoleColor.Red; // Выделим "нет" красным
        Console.Write("нет");
        Console.ResetColor();
        Console.WriteLine(" третьей цифры");
    }
    if (number >= 100)
    {
        // Перевод текстового элемента строки в число на всякий случай
        char tempNum = str[2];
        int num2 = int.Parse(tempNum.ToString());
        Console.WriteLine(num2);
    }
    if (number <= -100)
    {
        // Перевод текстового элемента строки в число на всякий случай
        // В строке индексация как и в массиве, знак "-" будет иметь индекс [0]
        char tempNum = str[3];
        int num2 = int.Parse(tempNum.ToString());
        Console.WriteLine(num2);
    }
    range = range / 10; // Для разнообразия принудительно уменьшим разрядность числа
    count++;
}