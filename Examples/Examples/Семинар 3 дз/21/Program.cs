// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// AB^2=(x2-x1)^2 + (y2-y1)^2 + (z2-z1)^2
Console.WriteLine("Введите X первой точки");
    int x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки");
    int y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки");
    int z1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй точки");
    int x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки");
    int y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки");
    int z2=Convert.ToInt32(Console.ReadLine());
if (x1==0 || y1==0 || z1==0 || x2==0 || y2==0 || z2==0 )
{
    Console.WriteLine("Точки не должны равняться 0");
    return;
}
int a=x2-x1, b=y2-y1, c=z2-z1;
double result1=Math.Pow(a, 2);
double result2=Math.Pow(b, 2);
double result3=Math.Pow(c,2);
Console.WriteLine($"квадрат первой разницы {result1}");
Console.WriteLine($"квадрат второй разницы {result2}");
Console.WriteLine($"квадрат третьей разницы {result3}");
double S=result1+result2+result3;
Console.WriteLine(S);
S=Convert.ToInt32(Math.Sqrt(S));
Console.WriteLine($"Расстояние между точками равно {S}");
