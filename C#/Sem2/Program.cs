// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число N: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int digits = 0;
string = "";
int processing = number;
if (number < 100 && number > -100) out = "третьей цифры нет";
while (processing <> 0){
    digits++;
    processing = processing/10;
}
Console.WriteLine(digits);
