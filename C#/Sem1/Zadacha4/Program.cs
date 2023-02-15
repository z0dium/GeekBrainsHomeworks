// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;
Console.WriteLine(max);