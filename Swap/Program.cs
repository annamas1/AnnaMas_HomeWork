// Swap - метод обмена значениями

void Swap(ref int a,ref int b)//reference
{
    int t=a;
    a=b;
    b=t;
}

void Calculate(int a, int b,out int sum, out int sub)
{
    sum=a+b;
    sub=a-b;
}


int a=1;
int b=2;
System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");
a=4;
b=5;

int sum,sub;
Calculate(2,2,out sum,out sub);
