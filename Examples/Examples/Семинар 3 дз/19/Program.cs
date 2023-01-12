// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число число");
int a=Convert.ToInt32(Console.ReadLine());
int Digit1=a/1000;
int Digit2=a % 100;
if(a<10000||a>99999)
{
    Console.WriteLine("Число не пятизначное");
    return;
}
Console.WriteLine(Digit1);
Console.WriteLine(Digit2);
if (Digit1==Digit2)
{
    Console.WriteLine("Число палиндром");
}