// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber < secondNumber) Console.Write($"Число {secondNumber} больше, чем число {firstNumber}");
else if (firstNumber == secondNumber) Console.Write($"Число {secondNumber} равно числу {firstNumber}");
else Console.Write($"Число {firstNumber} больше, чем число {secondNumber}");