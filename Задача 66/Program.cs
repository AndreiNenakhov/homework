// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write( "Введите число М:  ");
int М = Convert.ToInt32(Console.ReadLine());

Console.Write ( "Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void GapnumberSum (int numberM, int numberN, int sum)
{
    if (numberM < numberN)
    {
        Console.WriteLine ($"Сумма натуральных элементов в промежутке от М до N: {sum} " );
        return;
    }
    + = = + (numberM ++);
    GapnumberSum (numberM,numberN,sum);
}

GapnumberSum (numberM, numberN, 0);