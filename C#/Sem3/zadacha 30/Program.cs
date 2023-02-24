// Задача 30
Console.Clear();
randomArray();

int[] randomArray() {
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(2);
        Console.Write(array[i]);
    }
    return array;
}
