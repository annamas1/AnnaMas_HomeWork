 
// 41.	В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

using System;
double[] a;
//InitDoubles(out a,2);
string s=System.Console.ReadLine();//96.03 92.59 24.86 47.64 63.36 49.43 56.10 63.48 83.89 96.94 1.37 53.75 91.96 23.03 47.71 11.01 70.64 2.02 66.49 13.79
string[] ss=s.Split(' ');//"96.03" "92.59" "24.86" "47.64" "63.36" 49.43 56.10 63.48 83.89 96.94 1.37 53.75 91.96 23.03 47.71 11.01 70.64 2.02 66.49 13.79
a=Array.ConvertAll<string,double>(ss,Convert.ToDouble);
double min,max;
FindMinMax(a,out min,out max);
//Print(a);
//System.Console.WriteLine();
System.Console.WriteLine(max-min);

void InitDoubles(out double[] a,int Length=10,int min=0,int max=100)
{
    a=new double[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1)/1000.0;
}

void FindMinMax(double[] a,out double min, out double max)
{
    min=a[0];
    max=a[0];
    for(int i=1;i<a.Length;i++)
    {
        if (a[i]>max) max=a[i];
        if (a[i]<min) min=a[i];
    }
}


void Print(double[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],6:F3} ");
}