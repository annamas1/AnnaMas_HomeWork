// 38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int N=5;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(10,99);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

int count=0;
for(int i=0;i<random.Next(10,99);i=i+2)
    
    count=count+1;
System.Console.WriteLine();
System.Console.WriteLine(count);