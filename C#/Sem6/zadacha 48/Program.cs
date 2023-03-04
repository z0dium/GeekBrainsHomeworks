// **Задача 48:** Задайте 
// двумерный массив размера m на n, каждый элемент
//  в массиве находится по формуле: A[i, j] = i + j. 
//Выведите полученный массив на экран.
printArray(getArray(3,4));

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

