// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число начала ряда: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число окончания ряда: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0; 

int Sum(int M, int N)
{
    if (N == M) // уcловие выхода из рекурсии
    {
        sum = sum + M;
        
    }
    else
    {
        sum = sum + N;
        Sum(M, N-1);
    }
    return sum;
}

Console.Write(Sum(M, N));