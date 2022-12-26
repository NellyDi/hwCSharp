// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"число {A} в натуральной степени {B} равно {GetDegree(A, B)}");

int GetDegree(int num1, int num2)
{
    int degree = 1;
    while (num2 > 0)
    {
        degree = degree * num1;
        num2--;
    }
    return degree;
}