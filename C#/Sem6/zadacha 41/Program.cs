// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите числа через пробел: ");
string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Введено {countPositiveNumbers(parseStringOfNumbers(input))} чисел больше ноля");

int[] parseStringOfNumbers (string[] numbers){
    int[] result = new int[numbers.Length];
    for (int i=0; i < numbers.Length; i++){
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int countPositiveNumbers(int[] numbers){
    int result = 0;
    for (int i=0; i < numbers.Length; i++){
        if (numbers[i] > 0) result++;
    }
    return result;
}