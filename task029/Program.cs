// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран.


void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] num)
{
    int count = num.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(num[position] + " ");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();