//  **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.
Console.Clear();
Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());
convertAndPrint(number);

void convertAndPrint(int number){
    int processing = number;
    int count = 0;
    while (true)
    {
        processing = processing/2;
        count = count+1;
        if (processing == 0) break;
    }
    Console.WriteLine(count);
    processing = number;
    for (int i=count-1; i>=0; i--){
        Console.Write(processing/exp(2,i));
        processing = processing % exp(2,i);
    }
}
int exp(int number, int grade){
    int result = 1;
    if (grade == 0) return 1;
    for (int i=1; i<=grade; i++ ){
        result = result * number;
    }
    return result;
}
