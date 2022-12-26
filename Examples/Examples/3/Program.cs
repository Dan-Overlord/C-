// Задача №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число:");
    double a=Convert.ToInt32(Console.ReadLine());
        if (a % 2==0)
        {
            Console.WriteLine("Ваше число четное");
        }
        else 
        {
            Console.WriteLine("Ваше число не четное");
        };
     a=a/2;
     Console.WriteLine("При делении на два:");
     Console.WriteLine(a);