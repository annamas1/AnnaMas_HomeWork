// 22.	Программа проверяет пятизначное число на палиндромом.


int []array;
array=new int[21312];


if(array[0]==array[4] && array[1]==array[3])
{
    System.Console.Write($"число  палиндром");
    return;
}
if(array[0]!=array[4])
{
    System.Console.Write($"число  НЕ палиндром");
}

