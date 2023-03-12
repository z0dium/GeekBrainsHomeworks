// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();

int[,] array = getArray(4,4);
printArray(array);
Console.WriteLine();
Console.WriteLine(findLowesSumRow(array));

int[,] getArray(int m, int n){
    Random rnd = new Random();
    int[,] array = new int[m,n];
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

int findLowesSumRow(int[,] array){
    int min = 0;
    int index = 0;
    for (int j=0; j < array.GetLength(1); j++){
        min = min + array[0,j];
    }
    for (int i=1; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j=0; j < array.GetLength(1); j++){
            sum = sum + array[i,j];
        }
        if (min > sum) {
            min = sum;
            index = i;
        }
    }
    return index + 1;
}

