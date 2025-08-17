namespace Encapsulation
{
    internal class Program
    {
        private string StudentName;
        private int StudentAge;
        public void SetName(string StudentName)
        {
            if (string.IsNullOrEmpty(StudentName)==true) {
                Console.WriteLine("Proper Name is required");
            }
            else
            {
                this.StudentName=StudentName;
            }
                
        }
        public void GetName()
        {
            if (string.IsNullOrEmpty(this.StudentName)==true) 
            { Console.WriteLine("Enter valid input"); }
            else
            { Console.WriteLine("The Name of the student is:" +this.StudentName); }
        }
        public void SetAge(int StudentAge)
        {
            if (StudentAge >0)
            {
                this.StudentAge=StudentAge;
            }
            else
            {
                Console.WriteLine(  "Enter valid input");
            }
           
        }
        public void GetAge()
        {
            if (StudentAge >0)
            {
                Console.WriteLine("The Age of the student is:"+StudentAge);
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
    
        }
        static void Main(string[] args)
        {
            
            Program obj = new Program();
            obj.SetName("John");
            obj.SetAge(21);
            obj.GetName();
            obj.GetAge();
            obj.SetName("");//Prints else block
            obj.SetAge(-5);//Prints else block
            


        }
    }
}
