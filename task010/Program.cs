// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого 
// числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int num1 = number/10;
int result = num1%10;

Console.WriteLine($"Вторая цифра числа {number} --> {result}");
