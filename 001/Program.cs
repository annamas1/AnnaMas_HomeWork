//   1.	С клавиатуры вводится целое число. Вывести квадрат числа 

System.Console.WriteLine("Введите на клавиатуре целое число:");
int a;
int b;
string? s;
s = System.Console.ReadLine();
a = Convert.ToInt32(s);
b = a*a;
System.Console.WriteLine($"{a}^2={b}");