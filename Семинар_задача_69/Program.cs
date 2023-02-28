// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
//возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число степени: ");
int B = Convert.ToInt32(Console.ReadLine());


int Power(int A, int B)
{
    int sum = 1;
    if (B == 1)
    {
       sum = A * sum;
    }
    else
    {
        sum = A * Power(A,B-1);
    }
    return sum; 
}

Console.WriteLine(Power(A,B));