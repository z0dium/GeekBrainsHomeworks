// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число N: ");
int number = int.Parse(Console.ReadLine());
while((99 > number && number < 1000) ^ (-1000 < number && number < -99)){
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число N: ");
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine(number / 10 % 10);