// 30.	Написать программу вычисления произведения чисел от 1 до N.


int i=1;
System.Console.Write($"{i} ");
i=i+1;
int N=7;
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+1;
    
}
int result = 1;
for(i = 1; i<=N; i++)
    result*=i;
System.Console.WriteLine($"сумма чисел = {result}");






