// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру N: ");
int digit = int.Parse(Console.ReadLine());
while (!(0 < digit && digit < 8)){
    Console.Write("Введите корректную цифру дня недели: ");
    digit = int.Parse(Console.ReadLine());
}
if (digit >= 6) Console.WriteLine("да");
else Console.WriteLine("нет");