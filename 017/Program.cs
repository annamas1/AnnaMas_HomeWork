// 17.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

int dayOfWeek; 
dayOfWeek=Convert.ToInt32(Console.ReadLine());

if (dayOfWeek == 1) System.Console.WriteLine("Monday");
if (dayOfWeek == 2) System.Console.WriteLine("Tuesday");
if (dayOfWeek == 3) System.Console.WriteLine("Wednesday");
if (dayOfWeek == 4) System.Console.WriteLine("Thursday");
if (dayOfWeek == 5) System.Console.WriteLine("Friday");
if (dayOfWeek == 6) System.Console.WriteLine("Saturday");
if (dayOfWeek == 7) System.Console.WriteLine("Sunday");

bool b=(dayOfWeek== 6);
bool c=(dayOfWeek== 7);
if (b)
{
    System.Console.WriteLine("This is - Weekend!");
}
if (c)
{
    System.Console.WriteLine("This is - Weekend!");
}
else
{
    System.Console.WriteLine("Workday :'(");
}
