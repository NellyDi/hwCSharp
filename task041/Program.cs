// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine()!);

int Count()
{
    int i = 0;
    int count = 0;
    while (i<m)
    {
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0) count += 1;
        i++;
    }
    return count;
}

Console.WriteLine(Count());