// Задача №4
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите сравниваемые числа:");
  int   a=Convert.ToInt32(Console.ReadLine()), 
        max=a,
        b=Convert.ToInt32(Console.ReadLine()),
        c=Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                max=a;
            }
           else if (b>c)
                {
                   max=b; 
                }
                    else max=c;
Console.WriteLine($"Максимальное число ={max}");   