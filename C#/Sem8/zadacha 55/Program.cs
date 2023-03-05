// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());
int[,] array = getArray(rows,cols);
printArray(array);
Console.WriteLine();
transposeArray(array);
printArray(array);

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

void transposeArray(int[,] array){
    if (array.GetLength(0) != array.GetLength(1)) {
        Console.WriteLine("Действие с данным массивом невозможно");
        return;
    }
    for (int i=0; i < array.GetLength(0); i++){
        for (int j=i; j < array.GetLength(1); j++){
            if (i == j) continue;
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}
