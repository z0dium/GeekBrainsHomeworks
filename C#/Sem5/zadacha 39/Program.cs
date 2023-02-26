// Задача 39:  Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random rnd = new Random();
Console.Write('[');
for (int i=0; i< size; i++){
    array[i] = rnd.Next(10);
    Console.Write(array[i]);
    if (i != size -1) Console.Write(' ');
}
Console.WriteLine(']');

for (int i=0; i < size/2; i++){
    int a = array[i];
    array[i] = array[size-1-i];
    array[size-1-i] = a;
}

Console.Write('[');
for (int i=0; i < size; i++){
    Console.Write(array[i]);
    if (i != size -1) Console.Write(' ');
}
Console.WriteLine(']');