// 35.	Написать программу замены элементов массива на противоположные.


int N=5;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,9);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
Console.WriteLine("   OK, затем нажми на клавиатуре ENTER");
string? s = Console.ReadLine();
Console.WriteLine("Хорошо, давайте посмотрим результат:");

