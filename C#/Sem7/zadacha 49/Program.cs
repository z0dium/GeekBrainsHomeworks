// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.
Console.Clear();
int[,] array = getArray(5,5);
printArray(array);
Console.WriteLine();
processArray(array);
printArray(array);

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

void processArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (((i + 1) % 2 == 0) && ((j + 1) % 2 == 0)) array[i,j] = array[i,j]*array[i,j];
        }
    }
}