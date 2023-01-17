// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
string answer = Console.ReadLine();
int number=Convert.ToInt32(answer), sum=0, digit=0;
digit=number % 10;
while(number > 0)
{
digit=number % 10;
number = number/10;
sum=sum+digit;
}
Console.WriteLine(digit);
Console.WriteLine(sum);

