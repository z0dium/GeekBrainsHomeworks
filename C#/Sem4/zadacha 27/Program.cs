// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число, сумму цифр которого нужно посчитать: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(findSumOfDigits(number));

int findSumOfDigits(int arg){
    int result = 0;
    int processing = arg;
    while (true){
        result += processing % 10;
        processing = processing / 10;
        if (processing == 0) return result;
    }
}

