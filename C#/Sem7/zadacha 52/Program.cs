//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = getArray(4,4);
printArray(array);
printAverageForColumns(array);

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

void printAverageForColumns (int[,] array){
    Console.WriteLine();
    for (int i=0; i < array.GetLength(1); i++){
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++){
            result += array[j,i];
        }
        Console.Write(Math.Round(result/array.GetLength(1),2,MidpointRounding.AwayFromZero) + " ");
    }
}