// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
print(m,n);

void print(int x, int y){
    min = x < y ? x : y;
    max = x < y ? y : x;
    if (x == y) Console.Write(x + " ");
    }  
}

