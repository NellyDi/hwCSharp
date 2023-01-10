// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double [size];
    Random random = new Random();
    for(int i = 0; i<size; i++)
    {
        res[i] = random.NextDouble() * 100;
        Console.Write($"{res[i]:F2} ");
    }
    
    return res;
}

double[] array = GetArray(6);
Console.WriteLine(array);

double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] > max) 
    {
        max = array[i]; 
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

double difference = max - min;

Console.WriteLine($"Максимальный элемент массива: {max:F2}");
Console.WriteLine($"Минимальный элемент массива: {min:F2}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference:F2}");


