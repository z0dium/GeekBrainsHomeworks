// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(calculate(m,n));

int calculate(int from, int to){
    if (from == to) return (to > 0 ? to : 0);
    else return (from > 0 ? from : 0) + calculate(((from < to) ? from + 1 : from - 1),to);  // отрицательные числа не натуральные
}