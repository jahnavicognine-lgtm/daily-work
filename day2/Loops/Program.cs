using System;
namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement example
            Console.WriteLine("Using if  loop");
            int i0 = 10;
            if (i0==10)
            {
                Console.WriteLine("i0 is equal to 10");
            }
            //if else statement example
            Console.WriteLine("Using if else loop");
            if (20>18) {
                Console.WriteLine("20 is greater than 18");
            }
            else
            {
                Console.WriteLine("18 is greater than 20");
            }

            //else if statement example
            Console.WriteLine("Using else if loop");
            int a = 10;
            int b = 83;
            if (a>b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a<b)
            {
                Console.WriteLine("a is less than b");
            }
            else
            {
                Console.WriteLine( +a+" is equal to"+b);
            }
            //for loop statement example
            Console.WriteLine("Using for loop");
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Value of i is :" +i);
            }
            //while loop statement example
            Console.WriteLine("Using while loop");
            int i1 = 0;
            while (i1<5)
            {
                Console.WriteLine("Value of i1 is: "+i1);
                i1++;
            }
            //do while loop statement example
            int i2 = 0;
            do
            {
                Console.WriteLine("Value of i2 is:" +i2);
                i2++;

            } while (i2<5);


        }
    }
}
