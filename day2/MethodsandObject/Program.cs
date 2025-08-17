using System;
namespace MethodsandObject
{

    internal class Program
    {
        class Class1
        {
            public int a;
            public string b;
            public bool c;
            public void Method1()
            {
                Console.WriteLine("The values of \ta,\tb,\tc:"  + a +","+"\t" + b +","+"\t"+ c+","+"\t");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 obj = new Class1();
            obj.a=10;
            obj.b="Good Morning";
            obj.c=false;
            obj.Method1();//calling of method1
            Class2 obj1 = new Class2();
            obj1.d=20;
            obj1.e="Good Evening";
            obj1.f=true;
            obj1.Method2();//calling of method2
        }
    }
    class Class2
    {
        public int d;
        public string e;
        public bool f;
        public void Method2()
        {
            Console.WriteLine("The value of \tb,\tc,\td:" + d+ ","+"\t"+ e +","+"\t"+ f+"\t");
        }

    }
}
