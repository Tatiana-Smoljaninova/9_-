// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1) Console.Write("Введите число больше 0");

// вызываем рекурсивную функцию
void Numbers(int N) // функция ничего не возвращает
{
    if (N == 1) // условие выхода из рекурсии
    {
        Console.Write($"{N} ");
    }
    else
    {
        Numbers(N-1); 
        Console.Write($"{N} ");     
    }
}

Numbers(N);