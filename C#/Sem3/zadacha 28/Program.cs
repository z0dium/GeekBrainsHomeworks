// Задача 28
Console.Clear();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(getFactorial(number));

long getFactorial(int number){
    long result = 1;
    for ( int i = 1; i <= number; i++){
        result *= i;
    }
    return result;
}

