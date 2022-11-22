// Задача 1 Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой 
// находится эта точка.


// int findQuart (double x, double y)
// {
//     if (x > 0 && y > 0) // четверть 1
//     return 1;

//     if (x < 0 && y > 0) // четверть 2
//     return 2;

//     if (x < 0 && y < 0) // четверть 3
//     return 3;

//     if (x > 0 && y > 0) // четверть 4
//     return 4;

//     return 0; // если ввод 0 или некоректный
// }

// Console.Write("Введите X: "); //ввод абциссы
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y: "); //ввод ординаты
// double y = Convert.ToDouble(Console.ReadLine()); 

// Console.WriteLine($"The quarter number of our poin {findQuart(x, y)}");

// Задача 2 Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


// void findCoordinate (int Quart)
// {
//     if (Quart < 1 || Quart > 4) // если ошибся пользователь
//     Console.WriteLine("Такой четверти не существует");

//     if (Quart == 1) // четверть 1
//     Console.WriteLine("Диапазон координат в 1 четверти X > 0, Y > 0");

//     if (Quart == 2) // четверть 2
//     Console.WriteLine("Диапазон координат в 1 четверти X < 0, Y > 0");

//     if (Quart == 3) // четверть 3
//     Console.WriteLine("Диапазон координат в 1 четверти X < 0, Y < 0");

//     if (Quart == 4) // четверть 4
//     Console.WriteLine("Диапазон координат в 1 четверти X > 0, Y < 0");
// }

// Console.Write("Введите четверть: "); //ввод четверти
// int Quart = Convert.ToInt32(Console.ReadLine());
// findCoordinate(Quart);

// Задача 3. (самостоятельно)
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// √ (x 2 - x 1) 2 + (y 2 - y 1) 2
// Math.sqrt(x)

// double Line (double x1, double y1, double x2, double y2)
// {
//     double coor_1 = Math.Round(Math.Sqrt(((x2 - x1)*(x2 - x1))+(y2 - y1)*(y2 - y1)));
//     Console.WriteLine(coor_1);
//     return coor_1;
// }
// Console.Write("Введите x1: "); 
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите x2: "); 
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите y1: "); 
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите y2: "); 
// double y2 = Convert.ToDouble(Console.ReadLine());

// Line(x1,x2,y1,y2);


//Задача 4. (самостоятельно)
// Напишите программу которая принимает на вход число (N) 
// и выдает на консоль квадраты чисел от 1 до N

void Quad (double N)
{
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"{i} -> {Math.Pow(i, 2)}");
    }
}
Console.Write("Введите число: "); 
double num = Convert.ToDouble(Console.ReadLine());
Quad(num);

