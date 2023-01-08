Console.WriteLine("Hello, World!");
int number=new Random().Next(10, 100);
int firstDigit = number / 10; 
int secondDigit = number % 10;

Console.WriteLine($"случайное число:{number}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа:{firstDigit}");
}

if(secondDigit > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра числа:{secondDigit}");
}

if(secondDigit == firstDigit)
{
    Console.WriteLine("Цифры числа равны");
}