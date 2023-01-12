Console.WriteLine("Введите X");
int X=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y");
int Y=Convert.ToInt32(Console.ReadLine());
if (X==0 || Y==0)
{
    Console.WriteLine("Точки не должны равняться 0");
    return;
}
if(X>0 && Y>0)
{
    Console.WriteLine("Точка находиться в первой четверти");
}
if(X<0 && Y>0)
{
    Console.WriteLine("Точка находиться во второй четверти");
}
if(X<0 && Y<0)
{
    Console.WriteLine("Точка находиться в третьей четверти");
}
if(X>0 && Y<0)
{
    Console.WriteLine("Точка находиться в четвертой четверти");
}