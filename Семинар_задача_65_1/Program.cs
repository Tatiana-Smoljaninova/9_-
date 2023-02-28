// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все  
// натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите начальное число ряда: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число ряда: ");
int N = Convert.ToInt32(Console.ReadLine());

void Numbers(int M, int N) // функция ничего не возвращает
{
    if (M == N) // уcловие выхода из рекурсии
    {
        Console.Write($"{M} ");
    }
    else
    {
        Numbers(M, N - 1);
        Console.Write($"{N} ");
    }
}

Numbers(M, N);