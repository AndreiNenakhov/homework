// // Задача 23
// // Напишите программу, которая принимает на вход число (N)
// // и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125.


// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"{i * i * i} ");
// }
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



numbers = [1,8,3,8,2,6,8,8]
index = 0
maximum = numbers[Index]
count_maximal = 0
while index < numbers.length do
    if numbers[index] > maximum the
         maximum = numbers [index]
         count_maximal = 1
    else
       numbers[index] == maximum the
         count_maximal = count_maximal + 1
    index = index + 1
    print(count_maximal)
    
