/* Задача 4: Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите три числа через Enter");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("max number = " + max);
    }
    else
    {
        max = c;
        Console.WriteLine("max number = " + max);
    }
}
else if (b > c)
{
    max = b;
    Console.WriteLine("max number = " + max);
}
else
{
    max = c;
    Console.WriteLine("max number = " + max);
}