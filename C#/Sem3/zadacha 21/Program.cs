// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координату Х первой точки: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int Z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int Y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int Z2 = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1)));