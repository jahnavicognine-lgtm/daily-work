//Single inheritance
namespace Inheritance
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            User obj = new User();
            Admin obj1 = new Admin();
            obj1.AdminId=1;
            obj1.AdminName="grace";
            obj1.AdminAge=22;
            obj1.AdminContactNo=8075836897;
            obj1.UserName="Jack";
            obj1.UserPassword=3868;
            obj1.Display();
        }
        class User //Base class(parent class)
        {
            public string UserName;
            public int UserPassword;

        }
        class Admin : User //Derived class(child class)
        {
            public int AdminId;
            public string AdminName;
            public int AdminAge;
            public long AdminContactNo;
            public void Display()
            {
                Console.WriteLine(AdminId);
                Console.WriteLine(AdminName);
                Console.WriteLine(AdminAge);
                Console.WriteLine(AdminContactNo);
                Console.WriteLine(UserName);
                Console.WriteLine(UserPassword);
            }
        }

    }
}

//Multi Level inheritance
/*using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User obj = new User();
            Customer obj1 = new Customer();
            PremiumCustomer obj2 = new PremiumCustomer();
            obj.UserName="Alice";
            obj1.UserName="Buntu";
            obj.Login();
            obj.Logout();
            obj.AnotherLogin();
            obj1.PlaceOrder();
            obj1.ViewOrderHistory();
            obj2.RedeemPoints();
            obj2.ApplyDiscount();
            obj2.UpgradeMembership();
            

        }
        class User //Base class(parent class
        {
            public string UserName;
            public int Password;
            public string FullName;
            public int PhoneNumber;
            public DateOnly DateOfRegistration;
            public void Login()
            {
                Console.WriteLine("User\t"+UserName+" Logged In Successfull");
            }
            
            public void Logout()
            {
                Console.WriteLine("User\t"+UserName+" Logged Out Successfull");
            }
            public void AnotherLogin()
            {
                Console.WriteLine("Another User Logged In Sucessfull");
            }

        }

        class Customer : User //Derived clas(child class
        {
            public int CustomerId;
            public string Email;
            public string Address;
            public void PlaceOrder()
            {
                Console.WriteLine($"{UserName}  place an order  ");
            }
            public void ViewOrderHistory(
                ) { Console.WriteLine($"{UserName}'s past orders: Utensils,Mats"); }

        }
        class PremiumCustomer : Customer //Derived Class (child class)
        { public int DiscountPercentage;
            public int RewardPoints;
            public string MembershipLevel;
            public DateOnly ExpiryDateOfMembership;
            public void RedeemPoints() {
                Console.WriteLine("RedeemPoints are 500");
            }
            public void ApplyDiscount() {
                Console.WriteLine("ApplyDiscount of 75%");
            }
            public void UpgradeMembership() {
                Console.WriteLine("Upgrade Membership to Gold");
            }
        }
    } }
*/
//Hierchical inheritance 
/*namespace Inheritance
{
    internal class Program
    {
        class Employee//Base class(parent class)
        {
            public int Empid;
            public string EmpName;
            public int EmpAge;
            public long EmpContactNo;

        }
        class Vistingemployee : Employee//Derived class(child class)
        {
            public int vistingSalary;
            public int vistingHours;
            public void display()
            {
                Console.WriteLine(vistingHours);
                Console.WriteLine(vistingSalary);
                Console.WriteLine(Empid);
                Console.WriteLine(EmpName);
                Console.WriteLine(EmpAge);
                Console.WriteLine(EmpContactNo);
            }

        }
        class Permanantemployee : Employee//Derived class(child class)
        {
            public int permanantSalary;
            public int permanantHours;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Permanantemployee obj2 = new Permanantemployee();
            Vistingemployee obj1 = new Vistingemployee();
            Employee obj = new Employee();
            obj2.EmpAge=46;
            obj2.EmpContactNo=9177003925;
            obj2.permanantSalary=45000;
            obj2.permanantHours=5;
            obj2.EmpName="Dev";
            Console.WriteLine($"The EmpName that is inherited by the Parent class that is Employee: {obj2.EmpName}");
            obj1.EmpContactNo=9009334783;
            obj1.Empid=79;
            obj1.EmpName="wales";
            obj1.EmpAge=34;
            obj1.vistingHours=3;
            obj1.vistingSalary=30000;
            obj1.display();



        }
    }
}

*/
//C# does not support multiple class inheritance directly, but a class can implement multiple interfaces.
//Hybrid Inheritance in C#, it's achieved using classes + interfaces.