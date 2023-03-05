// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.WriteLine("Чтобы найти точку пересечения прямых заданных уравнением вида y=kx + b");
Console.Write("Введите числа b1, k1, b2 и k2 через пробел: ");
string[] koefs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(koefs[0]);
double k1 = double.Parse(koefs[1]);
double b2 = double.Parse(koefs[2]);
double k2 = double.Parse(koefs[3]);
if (k1 == k2) Console.WriteLine("У заданных прямых нет точек пересечния");
else {
    double X = (b2-b1)/(k1-k2);
    double Y = k1*X + b1;
    Console.WriteLine($"Прямые пересекаются в точке ({X},{Y})");
}