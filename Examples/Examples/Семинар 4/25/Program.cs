// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите числа...");
int number1=Convert.ToInt32(Console.ReadLine()),
    number2=Convert.ToInt32(Console.ReadLine()),
    i=1;
while(number2 !=0)
{   
i=number1 * i;   
number2 = number2-1 ;
}
Console.WriteLine(i);
Console.WriteLine(number2);