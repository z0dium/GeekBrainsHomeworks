// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());
int[,] array = getArray(rows,cols);
printArray(array);
Console.WriteLine();
Console.Write("Введите координаты элемента через пробел (строка, столбец): ");
string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
if (input.Length != 2) Console.WriteLine("Неправильное количество координат.");
else {
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    if (x > array.GetLength(0) || y > array.GetLength(1)) Console.WriteLine("Такого элемента нет.");
    else{
        Console.WriteLine(array[x-1,y-1]);
    }
}

int[,] getArray(int m, int n){
    int[,] array = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i,j] = rnd.Next(10,100);
        }
    }
    return array;
}

void printArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
