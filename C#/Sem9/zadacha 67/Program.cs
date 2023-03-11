// Задача 67 Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(number));

int SumNumbers(int number) {
    if (number == 0) return 0;
    return number % 10 + SumNumbers(number / 10);
}



