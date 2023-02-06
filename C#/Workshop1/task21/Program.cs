// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Переместимся в трехмерное пространство.\nИ посчитаем расстояние между двумя точками.");

// Организуем все в виде небольщой таблички
Console.WriteLine("X     Y     Z".PadLeft(42)); // Сместим для центрирования
Console.WriteLine(("-------------").PadLeft(42)); // Подчеркнем для красоты

// В этом блоке для ввода координаты устанавливаем курсор в нужное место и оттуда считываем значение
Console.Write("Введите координаты точки А:  ");
int Ax = int.Parse(Console.ReadLine());
Console.SetCursorPosition(35, 4);
int Ay = int.Parse(Console.ReadLine());
Console.SetCursorPosition(40, 4);
int Az = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B:  ");
int Bx = int.Parse(Console.ReadLine());
Console.SetCursorPosition(35, 5);
int By = int.Parse(Console.ReadLine());
Console.SetCursorPosition(40, 5);
int Bz = int.Parse(Console.ReadLine());

// Вычислим расстояние между точками и округлим полученный результат
double S = Math.Round(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2)), 2);
Console.WriteLine($"Расстояние между точками A и B равно ~{S}");