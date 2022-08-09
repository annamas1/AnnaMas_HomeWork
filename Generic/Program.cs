// Термин обобщение, по существу, означает параметризированный тип. 
//Особая роль параметризированных типов состоит в том, что они позволяют создавать классы, структуры, 
//интерфейсы, методы и делегаты, в которых обрабатываемые данные указываются в виде параметра.

//GENERIC (Обобщения, шаблоны)

class Program
{
    /*
    public static void Swap(ref int a,ref int b)
    {
        int t=a;
        a=b;
        b=t;
    }
    public static void Swap(ref double a,ref double b)
    {
        double t=a;
        a=b;
        b=t;
    }
     public static     void Swap(ref string a,ref string b)
    {
        string t=a;
        a=b;
        b=t;
    }
    */
    //Generic (обобощенные метод)

//T - параметризированный тип
    public static void Swap<T>(ref T a,ref T b)
    {
        T t=a;
        a=b;
        b=t;
    }



    public static void Init(out int[] a)
    {
        a=new int[10];
        for(int i=0;i<10;i++)
            a[i]=10;
    }


}

class MyClass
{
        static void Main()
    {
        List<int> list=new List<int>();
        LinkedList<string> linkedList=new LinkedList<string>();
        
        int[] a;
        int x=1,y=2;
        double e=2,t=4;
        
        Program.Swap<int>(ref x,ref y);
        Program.Swap<double>(ref e,ref t);
        Program.Init(out a);        
    }
}
