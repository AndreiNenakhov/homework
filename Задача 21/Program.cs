// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A(3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите кординаты X1 : ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординаты Y1 : ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординаты Z1 : ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординаты X2 : ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординаты Y2 : ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординаты Z2 : ");
int Z2 = int.Parse(Console.ReadLine()!);
int A = (X2 - X1);
int B = (Y2 - Y1);
int C = (Z1 - Z2);
Double Length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {Length}");
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
