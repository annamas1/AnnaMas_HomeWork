// 21.	Задать номер четверти, показать диапазоны для возможных координат.

int AreaN(double x, double y)
{
    //Отладочная
    //System.Console.WriteLine($"x={x} y={y}");
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;
}
