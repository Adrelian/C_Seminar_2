// Задача 1 Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой 
// находится эта точка.


int findQuart (double x, double y)
{
    if (x > 0 && y > 0) // четверть 1
    return 1;

    if (x < 0 && y > 0) // четверть 2
    return 2;

    if (x < 0 && y < 0) // четверть 3
    return 3;

    if (x > 0 && y > 0) // четверть 4
    return 4;

    return 0; // если ввод 0 или некоректный
}

Console.Write("Введите X: "); //ввод абциссы
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y: "); //ввод ординаты
double y = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine($"The quarter number of our poin {findQuart(x, y)}");