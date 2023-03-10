// Написать цикл, который принимает на вохд два числа (A и B) и возводит число А в натуральную степень В
// 3, 5 -> 243 (3 в пятой степени)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} равно {MyExpo(A, B)}.");

int MyExpo(int firstNum, int secondNum) // Объявляем метод. Названия параметров могут быть любые.
// Главное, чтобы параметры и передаваемые потом в метод аргументы были одинакового типа. 
// Переменные внутри метода можно объявить прям здесь в названиях параметров. 
// Но тогда их значения первоначально будут равны 0 (см задачу 27).
{
    int result = A; // Создадим временную переменную, чтоб не трогать А
    for (int i = 1; i < B; i++) { result = result * A; } // Перемножаем А на А В раз
    return result;
}