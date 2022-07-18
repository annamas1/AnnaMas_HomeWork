// 18.	По двум заданным числам проверять является ли одно квадратом другого. 
//Используйте подпрограмму.

bool Check(int a, int b)
{
    return a*a==b || b*b==a;
}

int a=50;
int b=5;
if (Check(a,b))
{
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не является");
}










//Сумма двух чисел
int Sum(int a,int b)
{
    //тело подпрограммы
    return a+b;
}

void Pause()
{   
    Console.ReadKey();
}

