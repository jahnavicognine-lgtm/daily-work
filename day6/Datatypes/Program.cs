//code 1
using System.Security.Cryptography.X509Certificates;

namespace Datatypes
{
    internal class Program
    {
        static float a = 25789.5632f;
        static double b = 23893482384.3864384d;
        static decimal c = 3738228328036538023.678357838237m;
        static string d = "\'Welcome to tutorial\'";
        static string e = "\t Welcome to tutorial";
        static string f = "Welcome \nto\n tutorial";
        static string g = @"Welcome \\ to\\ tutorial";//->@ displays it as it is
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(+a);
            Console.WriteLine(+b);
            Console.WriteLine(+c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine("Hello, World!");
            int h = 20;
            float i = h;//implicit conversion of int to float (implicit conversion is done by the compiler)
            float j = 25;
            int k = Convert.ToInt32(j);
            Console.WriteLine(k);
            //using parse -parse takes the input as string and then converts into the required datatype
            string l = "75.34";
            string m = "4738.34";//explicit conversion
            float n = float.Parse(l)+float.Parse(m);
            Console.WriteLine(n);
        }
    }
}


//code 2 
//constant keyword
/*using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Datatypes
{
    internal class Program
    {
        const string Companyname = "Cognine";
        public void Method1()
        {
            const int o = 25;
            Console.WriteLine(o);
        }
        Program()
        {
            const int p = 78;
            Console.WriteLine(p);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Companyname);
            Program obj = new Program();
            obj.Method1();


        }
    }
}*/


//code 3
//var
/*namespace Datatypes
{
    internal class Program
    {
        public void Method2()
        {
            var q = 67;
            Console.WriteLine(q);
        }
        Program()
        {
            var s = 90;
            Console.WriteLine(s);
        }
        public static void Main(String[] args)
        {
            var r = 67;
            r=56;
            Program obj1 = new Program();
            obj1.Method2();
            Console.WriteLine(r);
        }
    }
}*/


//code 4
//dynamic
/*namespace Datatypes
{
    internal class Program
    {
        public dynamic u = "morning";
        public static dynamic y = 25;

        public void Method1()
        {
            dynamic x = 89;
            x="changing x";
            Console.WriteLine("Method value" +x);

        }
        Program()
        {
            dynamic w = 67;
            w="changing w";
            Console.WriteLine("Constructor value" +w);
        }
        public static void Main(String[] args)
        {
            Program obj2 = new Program();
            dynamic s = 10;
            s ="Hello  morning";
            Console.WriteLine(s);
            Console.WriteLine(obj2.u);
            Console.WriteLine("Declared in the global variable" +y);
            obj2.Method1();

        }
    }
}*/


//code 5
//readonly
/*namespace Datatypes
{
    internal class Program
    {
        public readonly int z = 25;
        public readonly int a1;
        Program(int a1)
        {
           
            Console.WriteLine(a1++);
            Console.WriteLine(a1);
        }
        public static void Main(string[] args)
        {
            Program obj3 = new Program(78);
            Console.WriteLine(obj3.z);


        }
    }
}*/