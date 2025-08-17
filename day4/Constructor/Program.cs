namespace Constructor
{
    internal class Program
    {
        public int x;
        public int y=10;
        public Program()
        {
            x=10;
            Console.WriteLine("Non  static constructor called");
        }
        static Program() {
            //cannot declare the variables except local variables here because static variables  are declared at runtime
            Console.WriteLine("Static constructor is called");
        }
        static void Main(string[] args)
        {
            
            Program obj = new Program();
            Console.WriteLine("The value of X:" +obj.x +"\tand Y:"+obj.y);
        }
    }
}
