// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetRandomArray(int size, int RightRange, int LeftRange)
{
    int[] array = new int[size];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange + 1);
    }
    return array;
}
int[] massive = GetRandomArray(30,30,0);
Console.WriteLine(string.Join(",", massive));
int sum=0;
for(int i=0; i < massive.Length;i++)
{
    if(massive[i] % 2 != 0)
    {
         sum=sum+massive[i]; 
    }
}
Console.WriteLine($"Сумма нечетных элементов равна...{sum}");