// Задача 26
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int getLength(int input){
    int digits = 0;
    int processing = number >= 0 ? number:-number;
    while (processing > 0) {
        digits = digits + 1;
        processing = processing / 10;
    }
    return digits;
}

Console.WriteLine(getLength(number));
