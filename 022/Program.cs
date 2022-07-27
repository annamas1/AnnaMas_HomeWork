// 22.	Программа проверяет пятизначное число на палиндромом.

int a = 31413;
int[] array = {a};
int find = 31413;
int index = 0;
while(index<a)
{
    if(array[index] == find)
    {
        System.Console.WriteLine("это палиндром");
        break;
    }
    index++;
    if(array[index] == find)
    {
        System.Console.WriteLine("это НЕ палиндром");
        break;
    }
}
