// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();

int[,] array = getArray(4,4);
printArray(array);
Console.WriteLine();
changeArray(array);
printArray(array);

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

void changeArray(int[,] array){
    for (int i=0; i<array.GetLength(0);i++){
        int[] temp = new int[array.GetLength(0)];
        for (int j=0; j < array.GetLength(1); j++){
            temp[j] = array[i,j];
        }
        temp = sortArray(temp);
        for (int j=0; j < array.GetLength(1); j++){
            array[i,j] = temp[j];
        }
    }
}

int[] sortArray(int[] array){
    int[] result = array;
    for (int i=array.GetLength(0)-1; i >= 0; i--){
        int min = array[0];
        int index = 0;
        for (int j=0; j < i+1; j++){
            if (array[j] < min) {
                min = array[j];
                index = j;
            }
        }
        int temp = array[i];
        result[i] = min;
        result[index] = temp;
    }
    return result;
}
