// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] GetRandomArray(int size, int RightRange, int LeftRange)
{
    int[] array = new int[size];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange + 1);
    }
    return array;
}
int[] massive = GetRandomArray(10,100,0);
Console.WriteLine(string.Join(",", massive));
int max=0, min=100;
for(int i = 0; i < massive.Length; i++)
{
    if(massive[i]>max)
    {
        max=massive[i];
    }
    else if(massive[i]<max)
    {
        min=massive[i];
    }      
}
for(int i = 0; i < massive.Length; i++)
{
    if(massive[i] < min)
    {
        min=massive[i];
    }
}
Console.WriteLine($"Максимальный элемент {max}");
Console.WriteLine($"Минимальный элемент {min}");
Console.WriteLine($"Разница {max - min}");
