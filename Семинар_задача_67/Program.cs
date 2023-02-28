// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать 
//сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int summ = 0;

int Sum(int num)
{
    if (num / 10 == 0) // условие выхода
    {
       summ = summ + num;
    }
    else
    {
        Sum(num / 10);
        summ = summ + num % 10;
    }
    return summ;   
}

Console.WriteLine(Sum(num));
     
Sum(num);