// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int[] array = createArray();
showArray(array);
Console.WriteLine(countEven(array));

int[] createArray(){
    int[] array = new int[10];
    var rnd = new Random();
    for (int i=0; i < array.Length; i++){
        array[i] = rnd.Next(100,999);
    }
    return array;
}

int countEven(int[] array){
    int count = 0;
    for (int i=0; i< array.Length; i++){
        if (array[i]%2 == 0) count = count + 1;
    }
    return count;
}

void showArray(int[] array){
    for (int i=0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(" ");
        else Console.WriteLine();
    }
    
}

