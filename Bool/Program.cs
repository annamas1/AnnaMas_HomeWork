// Bool - это псевдоним для типа структуры System.Boolean .NET, 
// представляющий логическое значение: true или false.



/*//System.Int32 a=100;
int a=100;
//float f=3.14F;
double f=3.14;
bool b;
b=a>50;//простое условие //>,<,>=,<=,==,!=
b=true;
b=false;
if (b)
{
}
*/
//НЕ, И, ИЛИ, ИСКЛЮЧАЮЩЕЕ ИЛИ
//НЕ
bool passed = false;
//Console.WriteLine(!passed);  // output: True
//Console.WriteLine(!true);    // output: False
//И
//System.Console.WriteLine(false && false);
//System.Console.WriteLine(false && true);
//System.Console.WriteLine(true && false);
//System.Console.WriteLine(true && true);
//ИЛИ
//System.Console.WriteLine(false || false);
//System.Console.WriteLine(false || true);
//System.Console.WriteLine(true || false);
//System.Console.WriteLine(true || true);
//ИСКЛЮЧАЮЩЕЕ ИЛИ
System.Console.WriteLine(false ^ false);
System.Console.WriteLine(false ^ true);
System.Console.WriteLine(true ^ false);
System.Console.WriteLine(true ^ true);