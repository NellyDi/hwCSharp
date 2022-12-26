// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num} равна {GetSum(num)}");

int GetSum(int number)
{
    int sum = 0;
    int a = 0;
    while(number > 0)
    {
        a = number%10;
        sum = sum + a;
        number = number/10;
    }
    return sum;
}