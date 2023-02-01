// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GetRandomArray(int size, int RightRange, int LeftRange)
{
    int[] array = new int[size];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange + 1);
    }
    return array;
}
int[] massive = GetRandomArray(24,999,100);
Console.WriteLine(string.Join(",", massive));
int track=0;
for(int i = 0; i < massive.Length; i++)
{
    if(massive[i] % 2==0)
    {
         track=track + 1; 
    }
}
Console.WriteLine($"Количество четных чисел в массиве...{track}");

