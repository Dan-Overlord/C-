// Задача №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
    int N=Convert.ToInt32(Console.ReadLine()),
        Spin=1;
            while (Spin<N)
            {
                                if (Spin % 2==0)
                                {
                                     Console.WriteLine (Spin);
                                }
                Spin=Spin+1;
            }
            Console.WriteLine($"Счетчик={Spin}");