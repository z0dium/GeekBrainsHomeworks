// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
printResult(createArray(8,100));

int[] createArray(int size, int numberLimit) {
    int[] array = new int[size];
    Random random = new Random();
    for (int i=0; i<size; i++){
        array[i] = random.Next(numberLimit);
    }
    return array;
}

void printResult(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i<array.Length-1) Console.Write(",");
    }
    Console.WriteLine("]");
}
