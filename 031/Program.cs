// 31.	Показать кубы чисел, заканчивающихся на четную цифру.

int i=1;
int N=10;

while(i<=N)
{
    System.Console.WriteLine($"{i}^3 = {i*i*i}");
    i=i+1;

}

int a = i/2;
if (a==0)
{
    System.Console.WriteLine($"заканчиваются на четную цифру {a}");
    a=i/2;
}


