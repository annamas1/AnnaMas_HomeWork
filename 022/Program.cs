// 22.	Программа проверяет пятизначное число на палиндромом.


int N=30203;
int k=0;
while(N!=0)
{
    k++;
    N/=10;
}
System.Console.WriteLine(k);