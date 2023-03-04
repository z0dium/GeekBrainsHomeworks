// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = createArray();
showArray(array);
Console.WriteLine(countOddElementsSum(array));

int[] createArray(){
    int[] array = new int[10];
    var rnd = new Random();
    for (int i=0; i < array.Length; i++){
        array[i] = rnd.Next(100);
    }
    return array;
}

void showArray(int[] array){
    for (int i=0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(" ");
        else Console.WriteLine();
    }
    
}

int countOddElementsSum(int[] array){
    int sum = 0;
    for (int i=1; i< array.Length; i=i+2){
        sum = sum + array[i];
    }
    return sum;
}