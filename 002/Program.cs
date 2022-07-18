// 2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго.


Console.WriteLine("Введите на клавиатуре два числа:");
System.Console.WriteLine();
double a,b;
string? s = Console.ReadLine();
a = Convert.ToDouble(s);
s = Console.ReadLine();
b = Convert.ToDouble(s);

System.Console.WriteLine();
Console.WriteLine("Хорошо, давайте посмотрим результат:");
System.Console.WriteLine();
if (a*a == b)
{
    System.Console.Write(a);
    System.Console.Write(" является квадратом ");
    System.Console.Write(b);
}
else
{
   System.Console.Write(a);
   System.Console.Write(" НЕ является квадратом ");
   System.Console.Write(b); 
}
System.Console.WriteLine();
if (a == b*b)
{
   System.Console.Write(b);
   System.Console.Write(" является квадратом ");
   System.Console.Write(a); 
}
else
{
    System.Console.Write(b);
    System.Console.Write(" НЕ является квадратом ");
    System.Console.Write(a);  
}