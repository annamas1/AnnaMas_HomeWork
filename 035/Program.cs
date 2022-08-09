// 35.	Написать программу замены элементов массива на противоположные.


int N=5;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,9);
for(int i=0;i<a.Length;i++)
{
    System.Console.WriteLine($"{a[i], 4}  ");
    
}
System.Console.WriteLine($" OK, давайте посмотрим результат: ");    
for(int i=0;i<a.Length;i++)
{
    System.Console.WriteLine($"{a[i]/-1, 4}  ");
    
}    




