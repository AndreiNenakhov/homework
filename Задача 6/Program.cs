int num1, num2, num3;
Console.WriteLine("Ведите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("Максимальное число: + max");
Console.WriteLine(max);

