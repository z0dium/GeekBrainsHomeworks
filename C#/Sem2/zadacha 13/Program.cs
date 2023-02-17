// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число N: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int digits = 0;
string result = "";
int processing = number;
if (number < 100 && number > -100) result = "третьей цифры нет";
else {
    while ((processing != 0) && result.Length == 0){
    digits = digits + 1;
    processing = processing/10;
}
processing = number;
for (int i = 0; i<digits - 3; i++){
    processing = processing/10;
}
Console.WriteLine(processing % 10);
}
