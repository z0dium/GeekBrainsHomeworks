// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
Console.Write("Введите положительное число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(akkerman((long) m, (long) n));

long akkerman(long pM, long pN){
    if (pM == 0) return pN + 1;
    else if (pN == 0) return akkerman(pM - 1,1);
    else return akkerman(pM - 1,akkerman(pM,pN - 1));
}

