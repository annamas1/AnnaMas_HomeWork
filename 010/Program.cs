// 10.	Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int a = Convert.ToInt32(Console.ReadLine());

if (a>=10) System.Console.WriteLine(a/1%10);

if (a<=10) System.Console.WriteLine("Число имеет одну цифру");
