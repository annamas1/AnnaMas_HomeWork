// 31.	Показать кубы чисел, заканчивающихся на четную цифру.

int i=1;
int N=10;
int kub = i;
while(i<=N)
{
    while(i<=N)
        {
        System.Console.WriteLine($"{i}^3 = {i*i*i}");
        i=i+1;    
        }
    
    System.Console.WriteLine($"кубы чисел, заканчивающихся на четную цифру : ");
    System.Console.WriteLine($"{i}^3 = {i*i*i}");
}







