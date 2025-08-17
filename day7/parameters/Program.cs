//Named parameters
namespace Parameters
{
    internal class Program

    {
        public void Method1(string a, int b)
        {
            Console.WriteLine("The value of {a} and {b} is: " +a + b);
        }
        Program(bool c, float d)
        {
            Console.WriteLine("The value of c is: "+c);
            Console.WriteLine("The value of d is: "+d);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program obj = new Program(d: 25.79f, c: false);//every time i want to send a parameter than  i should create a object
            obj.Method1(b: 78, a: "Joice");
            obj.Method1("akshaya", 89);

        }
    }
}



///*params
/*namespace Parameters
{
    internal class Program
    {
        public void Method3(params string[] name)
        {
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main(params string[] args)
        {
            Program obj2 = new Program();
            obj2.Method3("string 1", "string 2", "string 3");
            obj2.Method3(new string[] { "string 4", "string 5", "string 6" });
        }
    }
}*/


//optional paramets
/*namespace Parameters
{
    internal class Program()
    {
        public void Method4(string Name = "NOT FOUND")
        {
            Console.WriteLine(Name);
        }

        public static void Main(string[] args)
        {
            Program obj3 = new Program();
            obj3.Method4("Jahnavi");
            obj3.Method4("Tenneti");
            obj3.Method4();
        }
    }
}

//ref parameter-affects the original value also
/*namespace Datatypes
{internal class Program
    {

        public void Method1(ref int a)
        {
            a = a+10;
            Console.WriteLine(a);
        }

        public static void Main(string[] args)
        {
            int value = 20;
            Console.WriteLine(value);
            Program obj4 = new Program();
            obj4.Method1(ref value); ;
        }
    }
}*/

//Out parameter
/*namespace Datatypes
{
    internal class Program
    {

        public void Method1(out int a)
        {
            a=100;//out parameter must be assigned before use
            Console.WriteLine(a);
        }

        public static void Main(string[] args)
        {
            int value = 20;
            Console.WriteLine(value);
            Program obj4 = new Program();
            obj4.Method1(out value); ;
        }
    }
}*/


//investigated question 
//asyn and awaits
/*using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace Parameters
{
    internal class Program
    {
        public static async Task Task1()//void should not be used
        {
            await Task.Run(async () =>
            {
                Console.WriteLine("Task 1 started...");
                await Task.Delay(4000);
                Console.WriteLine("Task 1 completed..");
            });


        }
        public async Task Task2()
        {
            await Task.Run(async () =>
            {
                Console.WriteLine("Task 2 started...");
                await Task.Delay(1000);
                Console.WriteLine("Task 2 completed...");
            });

        }
        public static async Task Main(string[] args)
        {
            Program obj4 = new Program();
            await Task1();
            await obj4.Task2();

        }
    }
}*/