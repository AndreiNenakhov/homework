// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("Третий цифры нет");

}
else
{
    while (num > 999)
    {
        num /= 10;
    }
    int thirdNumber = num % 10;
    Console.WriteLine($"Третья цифра числа -> {thirdNumber} ");

}
