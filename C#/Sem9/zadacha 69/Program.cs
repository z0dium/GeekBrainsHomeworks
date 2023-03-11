// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.
Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(exponentiate(A,B));

int exponentiate(int X, int Y){
    if (Y == 0) return 1;
    return X*exponentiate(X,Y-1);
}