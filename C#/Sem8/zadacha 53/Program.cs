// **Задача 53:** Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] array = getArray(5,5);
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
    for (int i=0; i<array.GetLength(1);i++){
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;
    }
}
    
