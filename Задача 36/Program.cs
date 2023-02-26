// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива: ");
        int length = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите минимальное значение массива: ");
        int min = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите максимальное значение массива: ");
        int max = int.Parse(Console.ReadLine()!);
        int[] Array = GetArray(length, min, max);
        Console.WriteLine($"[{string.Join(", ", Array)}]");
        FindOdd(Array);

        int[] GetArray(int size, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[] result = new int[size];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rnd.Next(minValue, maxValue + 1);
            }
            return result;
        }

        void FindOdd(int[] MyArray)
        {
            int Odd = 0;
            for (int i = 1; i < MyArray.Length; i = i + 2)
            {
                Odd = Odd + MyArray[i];
            }
            Console.WriteLine($"Сумма нечетных чисел {Odd}");
        }
    }
}