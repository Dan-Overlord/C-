// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.WriteLine("Введи число");
int A=Convert.ToInt32(Console.ReadLine()), i=0, summ=0;
while(i<=A)
{
    summ=summ+i;
    i++;
}
Console.WriteLine(summ);

