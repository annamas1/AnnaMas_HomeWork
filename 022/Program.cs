// 22.	Программа проверяет пятизначное число на палиндромом.


int []a;
a=new int[21312];
a[0]=2;
a[1]=1;
a[2]=3;
a[3]=1;
a[4]=2;

if(a[0] == a[4])
    {
        if(a[1]==a[3])
        System.Console.WriteLine("это палиндром");
        return;
    }
if(a[0] != a[4])
    {
        System.Console.WriteLine("это НЕ палиндром");
        
    }
