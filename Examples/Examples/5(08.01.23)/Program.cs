// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int     a=Convert.ToInt32(Console.ReadLine()),
        secondDigit= (a % 100)/10; 
if (a>999)
 {
    Console.WriteLine("ОШИБКА!!!Введите 3-значное число");
}
if (a<100)
{  
Console.WriteLine("ОШИБКА!!!Введите 3-значное число");
}
if (a<999)  
{ 
if (a>100)
{
Console.WriteLine($"Вторая цифра числа {secondDigit}");
}                                                   
}
   