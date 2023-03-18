// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} в степени {B} равно: {step(A, B)}");

int step(int a, int b)
{
    int rezult = 1;
    for (int i = 0; i < b; i++)
    {
        rezult = rezult * a;
    }
    return rezult;
}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SummDig(int number)

{
    int i = 0;
    int summ = 0;
    while (number > 0)
    {
        i++;
        summ += number % 10;
        number /= 10;
    }
    return summ;
}


Console.WriteLine("\nВведите число: ");
A = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {A} равна: {SummDig(A)}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
void PrintArray(int[] collection)
{
    int len = collection.Length;
    int index = 0;
    while (index < len)
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
}

int[] FillArrayRand(int size, int min, int max)
{
    int[] collection = new int[size];
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(min, max);
        index++;
    }
    return collection;
}

int Prompt (string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine()!);
}

int length = Prompt("Введите размерность массива: ");
int[] array = FillArrayRand(length, -50, 100);
PrintArray(array);
Console.WriteLine($"\n[{String.Join(", ", array)}]");

