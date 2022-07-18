// 3.	С клавиатуры вводятся два числа a и b. Найти максимальное из них

Console.WriteLine("Введите на клавиатуре два числа:");
double a,b;
string? s = Console.ReadLine();
a = Convert.ToDouble(s);
s = Console.ReadLine();
b = Convert.ToDouble(s);
Console.WriteLine("Хорошо, давайте посмотрим результат:");
double max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);