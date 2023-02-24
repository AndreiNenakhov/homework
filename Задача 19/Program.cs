// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число чтобы проверить, является ли это палиндромом:");
string text = Console.ReadLine();
int len = text.Length;
bool flag = true;
for (int i = 0; i < len / 2; i++)
{
    if (text[i] != text[len - (i + 1)])
    {
        flag = false;
        break;
    }
}
if (flag)
{
    Console.WriteLine("{0} Является палиндромом", text);
}
else
{
    Console.WriteLine("{0} не явлется палиндромом", text);
}
Console.ReadLine();

