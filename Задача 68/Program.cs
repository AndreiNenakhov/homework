// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int = = InputNumbers("Введите m: ");
int = = InputNumbers("Введите n: ");

int = = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack (m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string) 
{
  Console.Write (input);
  int = = Convert.ToInt32(Console.ReadLine());
  return output;
}