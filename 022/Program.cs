// 22.	Программа проверяет пятизначное число на палиндромом.


int length=30203;
int lenth = myString.Length;


for (int i = 0; i < length / 2; i++)
{
    if (myString[i] != myString[length - i - 1])
        return false;
}
return true;
System.Console.WriteLine(myString.Length());