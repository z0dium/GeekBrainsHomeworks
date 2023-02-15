// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число для проверки на четность: ");
int firstNumber = int.Parse(Console.ReadLine());
if (firstNumber%2 == 0) Console.WriteLine("четное");
else Console.WriteLine("нечетное");