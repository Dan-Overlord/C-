// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
string stop = "stop";
string answer = null;
int number, count = 0;
Console.WriteLine("Вводите числа...");
while(true)
{
    answer = Console.ReadLine();
        if (answer==stop)
        {
            break;
        }
    number = Convert.ToInt32(answer);
    if (number % 2 == 0)
    {
    count++;
    }
}
Console.WriteLine($"Чисел больше 0 введено было....{count}");

