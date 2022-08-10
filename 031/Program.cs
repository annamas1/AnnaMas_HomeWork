// 31.	Показать кубы чисел, заканчивающихся на четную цифру.

int i=1;
int N=10;
while(i<=N)
{
    while(i<=N)
    {
    System.Console.WriteLine($"{i}^3 = {i*i*i}");
    i=i+1;    
    }

}
if(i/i==0) System.Console.WriteLine($"{i}^3 = {i*i*i}");
i=i+1;



