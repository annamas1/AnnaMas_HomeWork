// 4.	По заданному с клавиатуры номеру дня недели вывести его название.

Console.WriteLine("Введите номер дня недели:");
int a = 1; 
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;
string? s =  Console.ReadLine();
a = Convert.ToInt32(s);
s = Console.ReadLine();
b = Convert.ToInt32(s);
c = Convert.ToInt32(s);
d = Convert.ToInt32(s);
e = Convert.ToInt32(s);
f = Convert.ToInt32(s);
g = Convert.ToInt32(s);

if (s=1)
{
    System.Console.WriteLine("Понедельник");
}
if (s=2)
{
    System.Console.WriteLine("Вторник");
}
if (s=3)
{
    System.Console.WriteLine("Среда");
}
if (s=d)
{
    System.Console.WriteLine("Четверг");
}
if (s=e)
{
    System.Console.WriteLine("Пятница");
}
if (s=g)
{
    System.Console.WriteLine("Суббота");
}
if (s=g)
{
    System.Console.WriteLine("Воскрескенье");
}


