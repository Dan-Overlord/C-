// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int i;
int[] a = new int[8];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 8; i++)
{
a[i] = Convert.ToInt32(Console.ReadLine());
}
 
for (i = 0; i < 8; i++)
{
Console.WriteLine(a[i]);
}


