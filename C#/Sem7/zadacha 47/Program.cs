// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
printArray(getArray(5,6));

double[,] getArray(int m, int n){
    double[,] array = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i,j] = Math.Round(rnd.NextDouble() * 100,2,MidpointRounding.AwayFromZero);
        }
    }
    return array;
}

void printArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
