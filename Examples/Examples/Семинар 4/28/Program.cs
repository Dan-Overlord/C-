//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введи число...");
int number=Convert.ToInt32(Console.ReadLine()), i=1, sum=1;
while(i<=number)
{
    sum=sum*i;
    i++;
}
Console.WriteLine(sum);
