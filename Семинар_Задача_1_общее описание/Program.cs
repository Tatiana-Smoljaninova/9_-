// Найдем факториал числа с помощью рекурсии

// int Fact(int num) // написали функцию, num - это число, факториал которого нужно найти 
// {
//     if (num == 1) // условие выхода из рекурсии
//         return 1;
//     return num * Fact(num - 1); // 
// }
// Console.WriteLine(Fact(5));


Console.Write("Введите число начала ряда: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число окончания ряда: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0; 

int Sum(int M, int N)
{
    if (N == M) // уcловие выхода из рекурсии
    {
        sum = sum + N;
        
    }
    else
    {
        Sum(M, N-1);
        sum = sum + N;        
    }
    return sum;
}

Console.Write(Sum(M, N));