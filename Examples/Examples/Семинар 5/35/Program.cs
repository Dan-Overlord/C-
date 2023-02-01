// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
int[] GetRandomArray(int size, int RightRange, int LeftRange)
{
    int[] array = new int[size];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange + 1);
    }
    return array;
}
int[] massive = GetRandomArray(123,150,0);
Console.WriteLine(string.Join(",", massive));
int track=0;
    for(int i=0; i < massive.Length; i++)
    {
        if(massive[i]<=99 & massive[i]>=10)
        {
            track=track + 1;
        }
    }
Console.WriteLine($"Количество эелементов в массиве...{track}");