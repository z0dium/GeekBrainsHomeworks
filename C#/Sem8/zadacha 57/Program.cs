// /* **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine());
int[,] array = getArray(rows,cols);
printArray(array);
Console.WriteLine();
printDictionay(makeDictinoray(array));

SortedDictionary<int,int> makeDictinoray(int[,] array){
    SortedDictionary<int,int> dict = new SortedDictionary<int,int>();
    for (int i=0; i < array.GetLength(0); i++){
        for (int j=0; j < array.GetLength(1); j++){
            if (dict.ContainsKey(array[i,j])) dict[array[i,j]] = dict[array[i,j]] + 1;
            else dict[array[i,j]] = 1;
        }
    }
    return dict;
}

void printDictionay(SortedDictionary<int,int> dict){
    foreach(var item in dict)
    {
        Console.WriteLine($"{item.Key} содержится {item.Value} раз.");
    }
}

int[,] getArray(int m, int n){
    int[,] array = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i,j] = rnd.Next(10);
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
