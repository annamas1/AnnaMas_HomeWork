// 37.	Задать массив, заполнить случайными положительными трёхзначными числами. Показать сумму чисел.
//Показать количество нечетных\четных чисел. --- не могу написать чтобы количество четных/нечетных считалось.

int N=5;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(100,200);
}
for(int j=0;j<a.Length;j++)
{
    System.Console.Write($"{a[j],4}");
}

int count=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]>0)
    {
        count=count+a[i];
    }
}

for(int i=0;i<a.Length;i++)
   
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных:{count}");












/*

int N=5;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(100,120);
}
for(int j=0;j<a.Length;j++)
    System.Console.Write($"{a[j],4}");

int count = j(
    a[0],    a[1],    a[2],    a[3],    a[4],    a[5],    a[6],    a[7]
);
{
    count = a[0]/2;
    while(count==0);
    System.Console.WriteLine(count);
}    
*/     

