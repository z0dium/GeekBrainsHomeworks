// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1; 1) и т.д.
Console.Clear();
int[,] array = getArray(4,5);
printArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали: {calculate(array)}");


int[,] getArray(int m, int n){
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i,j] = i + j;
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

int calculate(int[,] array){
    int diagonalLength = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1)
    int sum = 0;
    for (int i = 0; i < diagonalLength; i++){
        sum += array[i,i];
    }
    return sum;
}