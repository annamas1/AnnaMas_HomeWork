// 14.	С клавиатуры вводятся два числа a и b. 
//Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

Console.WriteLine("Введите на клавиатуре два числа:");
double a,b;
string? s = Console.ReadLine();
a = Convert.ToDouble(s);
s = Console.ReadLine();
b = Convert.ToDouble(s);

Console.WriteLine("Хорошо, давайте посмотрим результат:");

if (b/a==0) System.Console.WriteLine("Кратно");
if (b/a>=0) System.Console.WriteLine(b/a);
if (b/a<=0) System.Console.WriteLine(b/a);
