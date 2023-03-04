// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
double[] array = createArray();
showArray(array);
Console.WriteLine(findMaximum(array) - findMinimum(array));

double[] createArray(){
    double[] array = new double[10];
    var rnd = new Random();
    for (int i=0; i < array.Length; i++){
        array[i] = rnd.NextDouble();
    }
    return array;
}

void showArray(double[] array){
    for (int i=0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(" ");
        else Console.WriteLine();
    } 
}

double findMaximum(double[] array){
    double max = array[0];
    for (int i=1; i < array.Length; i++){
        if (array[i] > max) max = array[i];
    } 
    return max;
}

double findMinimum(double[] array){
    double min = array[0];
    for (int i=1; i < array.Length; i++){
        if (array[i] < min) min = array[i];
    } 
    return min;
}