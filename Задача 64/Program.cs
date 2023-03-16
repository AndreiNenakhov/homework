// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int = Convert.ToInt32(Console.ReadLine());

// NaturalToLow(number, count);


// void NaturalToLow(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         NaturalToLow(n, count  + 1);
//         Console.Write (count  + " ");
//     }
// }
Console.WriteLine("Введите натуральное число больше 1:");
int = int.Parse(Console.ReadLine());

void NumberCounter (int )
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number  == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);