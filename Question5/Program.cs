namespace Question5
{
    public class Programm
    {//non static variables are not part of the class ,they are part of the object


        public static void Main(string[] args)

        {
            Program obj = new Program();
            Program obj1 = new Program();
            Program obj2 = new Program();
            Program obj3 = new Program();

            obj.Method();
            obj1.Method();
            obj2.Method();
            obj3.Method();
            /*Program.Method1();*/

        }

    }

}
