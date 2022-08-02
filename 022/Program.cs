// 22.	Программа проверяет пятизначное число на палиндромом.

int a=21312;
int[] array = {a};
int n = array.Length;
int index = 0;
int find = a;
while(index<n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine("это палиндром");
        break;
    }
    index++;
}
while(index>n)
{
    if(array[index] != find)
    {
        System.Console.WriteLine("это НЕ палиндром");
        break;
    }
    index++;
}
