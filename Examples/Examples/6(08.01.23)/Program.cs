// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число");
int     a=Convert.ToInt32(Console.ReadLine()),
        thirdDigit= (a % 10); 
if (a>1000)
 {
    thirdDigit= (a % 100)/10;
}
    if (a>10000)
    {
        thirdDigit= (a % 1000)/100;
    }
        if (a>100000)
        {
            thirdDigit= (a % 10000)/1000;
        }
            if (a>1000000)
            {
                thirdDigit= (a % 100000)/10000;
            }
                if (a>10000000)
                {
                    thirdDigit= (a % 1000000)/100000;
                }
if (a<100)
{  
Console.WriteLine("ОШИБКА!!! В числе нет 3 цифр");
}
if (a>100)  
{ 
Console.WriteLine($"Третья цифра числа {thirdDigit}");
}                                                   

  
