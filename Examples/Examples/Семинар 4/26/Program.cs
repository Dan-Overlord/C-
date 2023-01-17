// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число");
string answer = Console.ReadLine();
int number=Convert.ToInt32(answer), i = 1;
while(number/10 != 0)
{
number = number/10;
i++;
}
Console.WriteLine(i);
