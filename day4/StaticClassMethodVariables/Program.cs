//static class
/*using System.Data;

namespace StaticClassMethodVariables
{
    internal class Program
    {
        class Class1
        {
           
           public  static int b = 10;//no need of using obj
           public int c = 20;
           public  int d;
        }
        public static class Class2//only static members are allowed into static class
        {
      
           public static int f = 89;
         

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 obj = new Class1();
           
            Console.WriteLine(Class1.b);
            Console.WriteLine(obj.c);
            Console.WriteLine(obj.d);
           
            Console.WriteLine(Class2.f);
            
            
        }
    }
}
*/

namespace StaticClassMethodVariables
{
    internal class Program
    {
        public static string Method()
        {
            Console.WriteLine("Static Method");
            return "hello";
        }
        public void Method1()
        {
            Console.WriteLine("Non Static Method");
        }
        public static void Main(string[] args) {
            Program obj = new Program();
            obj.Method1();
            Method();
        }
    }
}