//  **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
Console.Clear();
Console.Write("Введите длину первой стороны: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int third = int.Parse(Console.ReadLine());

if (first < second + third && second < first + third && third < first + second) Console.WriteLine("Треугольник с такими сторонами существует");
else Console.WriteLine("Треугольник с такими сторонами не существует");
