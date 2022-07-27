// 27.	Возведите число А в натуральную степень B используя цикл.

int i=1;
int A=10;
int B=8;

while(i<=A)
{
    System.Console.WriteLine($"{i}*{B} = {Math.Pow(i,B)}");
    i=i+1;    
}
