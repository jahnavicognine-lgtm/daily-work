//code 1

//Overriding - is performed only between base and derived classes
namespace Polymorphism
{
    internal class Program
    {
        class LoadParent//Base class
        {
            public string MotherName;
            public string FatherName;
            public int MotherAge;
            public int FatherAge;
            public virtual void  PMethod()//Overridden method
            {
                Console.WriteLine("Displaying the Parent Method (parent block)");
            }
            public void PMethod2()
            {
                Console.WriteLine("Displaying the Parent Method2 (parent block)");
            }
            public virtual void PMethod3()//Sealed keyword prevents from Overriding in derived classes
            {
                { Console.WriteLine("Displaying the Parent Methood3 (parent block)"); }

            }
            //new keyword is used to hide the base class
            public void PMethod4()
            {
                Console.WriteLine("Displaying the Parent Method4 (parent block) using new keyword");
            }
            public void PMethod5()
            {
                Console.WriteLine("SAME METHOD NAME Parent block");
            }
            public void PMethod6()
            {
                Console.WriteLine("allow parameter for same method declared in the parent and child class (parent block)");
            }
           
        }
        class LoadChild : LoadParent//Derived class
        {
            public string ChildName;
            public int ChildAge;
            public void CMethod()
            {
                Console.WriteLine("Displaying the Child Method (child block)");
            }
            public override void PMethod()//Overriding the base class method
            {
                Console.WriteLine("Displaying the Parent Method in the Child class(child block) ");
            }
            public sealed override void PMethod3()
            {
                Console.WriteLine("Displaying the Child Method3 (child block) using Sealed Keyword");
            }

            public new void PMethod4()
            {
                Console.WriteLine("Displaying the Child Method4 (child block) using new keyword");
            }
            public void PMethod5() {
                Console.WriteLine("SAME METHOD NAME Child block");
            }
            public void PMethod6(int a)
            {
                Console.WriteLine("allow parameter for same method declared in the parent and child class  (child block)");
            }

        }
            class LoadGrandChild : LoadChild
            {
                
            }

        
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LoadParent lp = new LoadParent();
            LoadGrandChild lgc = new LoadGrandChild();
         
            lgc.PMethod3();
           
            lp.PMethod(); 
            LoadChild cp = new LoadChild();
            cp.PMethod3();
            cp.CMethod();
            cp.PMethod();
            cp.PMethod2();
            lp.FatherName="FNAME";
            lp.MotherName="MNAME";
            lp.PMethod4();
            cp.PMethod4();
            lp.PMethod5();
            cp.PMethod5();
            LoadChild cp1 = new LoadChild();
            cp1.PMethod4();
            LoadParent lp1 = new LoadParent();
            lp1.PMethod4();
            LoadParent poly = new LoadChild();
            poly.PMethod4();   // Parent version, because `new` is hiding not overriding
            lp.PMethod6();
            cp.PMethod6(10);
          

        }
    }
}
//code 2

/*
Overloading-we define multiple methods with the same name by changing their parameters  
Overloading that allows us to define the same method name either in the same class or in derived class with different parameters
child class in overloading need not take permission from parent class to override the method.
In overloading not need of using inheritance 
*/

/*using System;
namespace Polymorphism
{
    internal class Program
    {
        class LoadParent
        {
            public void PMethod()
            {
                Console.WriteLine("Method of parent block");

            }
            public void PMethod1(int b, string c)
            {
                Console.WriteLine("Method1 of the parent block" +"\t"+c+ "\t"+b);
            }
            public void PMethod1(string c, int b)
            {
                Console.WriteLine("Method1 of the child block" +"\t"+c+"\t" +b);
            }

          
        }
        class LoadChild : LoadParent
        {
            public void PMethod(int a)
            {
                Console.WriteLine("Child class class block");
            }
            public void PMethod1(string c, int b)
            {
                Console.WriteLine("Method1 of the child block" +"\t"+c+"\t" +b);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LoadParent lp = new LoadParent();
            LoadChild lc = new LoadChild();
            lp.PMethod();
            lc.PMethod(10);
            lp.PMethod1(12, "Str1");
            lc.PMethod1("Str2", 10);//even though it is child class method it prints the parent class block because it is not overridden

        }
    }
}
*/