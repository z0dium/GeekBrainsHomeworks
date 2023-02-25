// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число, которое нужно будет возвести в степень: ");
double number = double.Parse(Console.ReadLine());
Console.Write("Введите степень для предыдущего числа: ");
int grade = int.Parse(Console.ReadLine());

double exponentiate(double X, int y){
    double result = 1;
    for (int i = 0; i < y; i++){
        result *= X;
    }
    return result;
}

Console.WriteLine (exponentiate(number, grade));