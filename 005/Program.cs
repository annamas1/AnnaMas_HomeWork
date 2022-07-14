// 5.	С клавиатуры вводятся три числа. Найти максимальное из трех чисел.

Console.WriteLine("Введите на клавиатуре три числа:");
int a,b,c;
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
s = Console.ReadLine();
b = Convert.ToInt32(s);
s = Console.ReadLine();
c = Convert.ToInt32(s);

Console.WriteLine("Хорошо, давайте посмотрим результат:");
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);