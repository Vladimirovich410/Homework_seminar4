// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число 
// A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А");
// double A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В");
// double B = Convert.ToInt32(Console.ReadLine());

// double result = A;
// for (int i = 1; i < B; i++)
// {
//     result = result * A;
// }
// Console.WriteLine($"{A} в степени {B} = {result}");


// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// string num = Console.ReadLine();

// int Num()
// {
//     Console.WriteLine("Введите число");
//     string num = Console.ReadLine();
//     int result = int.Parse(num);
//     return result;
// }

// int Sum(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum = sum + (number %10);
//         number = number / 10;
//     }
//     return sum;
// }

// int number = Num();
// Console.WriteLine($"Сумма чисел в введённом числе {number} равна {Sum(number)}");



// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void NewArray()
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10000);
        Console.Write($"{array[i]}, ");
    }

}
NewArray();
